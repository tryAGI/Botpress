#!/usr/bin/env python3
"""Merge multiple Botpress OpenAPI specs into a single spec."""
import json
import copy

SPEC_FILES = {
    "admin": "admin-openapi.json",
    "chat": "chat-openapi.json",
    "files": "files-openapi.json",
    "runtime": "runtime-openapi.json",
    "tables": "tables-openapi.json",
}


def main():
    specs = {}
    for name, path in SPEC_FILES.items():
        with open(path) as f:
            specs[name] = json.load(f)

    merged = {
        "openapi": "3.0.0",
        "info": {
            "title": "Botpress API",
            "description": "Unified Botpress API covering Admin, Chat, Files, Runtime, and Tables APIs.",
            "version": "1.0.0",
        },
        "servers": [{"url": "https://api.botpress.cloud"}],
        "security": [{"BearerAuth": []}],
        "paths": {},
        "components": {
            "securitySchemes": {
                "BearerAuth": {"type": "http", "scheme": "bearer"}
            },
            "schemas": {},
        },
    }

    schema_renames = {}

    for spec_name, spec in specs.items():
        prefix = spec_name.capitalize()

        # Merge schemas with prefix to avoid collisions
        for schema_name, schema_def in (
            spec.get("components", {}).get("schemas", {}).items()
        ):
            new_name = f"{prefix}{schema_name}"
            merged["components"]["schemas"][new_name] = schema_def
            old_ref = f"#/components/schemas/{schema_name}"
            new_ref = f"#/components/schemas/{new_name}"
            schema_renames[(spec_name, old_ref)] = new_ref

        # Merge paths
        for path, path_item in spec.get("paths", {}).items():
            if spec_name == "chat":
                actual_path = f"/chat-api{path}"
            else:
                actual_path = path

            new_path_item = copy.deepcopy(path_item)

            for method in ["get", "post", "put", "patch", "delete", "head", "options"]:
                if method in new_path_item:
                    op = new_path_item[method]
                    if "tags" not in op:
                        op["tags"] = []
                    op["tags"] = [prefix] + op.get("tags", [])
                    if "operationId" in op:
                        op["operationId"] = f"{prefix}_{op['operationId']}"
                    if spec_name == "chat" and "security" not in op:
                        op["security"] = [{"BearerAuth": []}]

            merged["paths"][actual_path] = new_path_item

    def fix_refs(obj, spec_name):
        if isinstance(obj, dict):
            new_obj = {}
            for k, v in obj.items():
                if (
                    k == "$ref"
                    and isinstance(v, str)
                    and v.startswith("#/components/schemas/")
                ):
                    key = (spec_name, v)
                    new_obj[k] = schema_renames.get(key, v)
                else:
                    new_obj[k] = fix_refs(v, spec_name)
            return new_obj
        elif isinstance(obj, list):
            return [fix_refs(item, spec_name) for item in obj]
        return obj

    # Fix refs in schemas
    for spec_name, spec in specs.items():
        prefix = spec_name.capitalize()
        for schema_name in spec.get("components", {}).get("schemas", {}):
            new_name = f"{prefix}{schema_name}"
            if new_name in merged["components"]["schemas"]:
                merged["components"]["schemas"][new_name] = fix_refs(
                    merged["components"]["schemas"][new_name], spec_name
                )

    # Fix refs in paths
    for spec_name, spec in specs.items():
        for path in spec.get("paths", {}):
            actual_path = f"/chat-api{path}" if spec_name == "chat" else path
            if actual_path in merged["paths"]:
                merged["paths"][actual_path] = fix_refs(
                    merged["paths"][actual_path], spec_name
                )

    with open("openapi.json", "w") as f:
        json.dump(merged, f, indent=2)

    print(f"Merged spec: {len(merged['paths'])} paths, {len(merged['components']['schemas'])} schemas")


if __name__ == "__main__":
    main()
