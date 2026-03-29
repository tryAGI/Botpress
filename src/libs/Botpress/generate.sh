#!/usr/bin/env bash
set -euo pipefail

# Botpress has 5 separate OpenAPI specs (Admin, Chat, Files, Runtime, Tables).
# We merge them into a single spec for generation.

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

# Download all 5 specs
curl -sL -o admin-openapi.json "https://raw.githubusercontent.com/botpress/docs/master/admin-openapi.json"
curl -sL -o chat-openapi.json "https://raw.githubusercontent.com/botpress/docs/master/chat-openapi.json"
curl -sL -o files-openapi.json "https://raw.githubusercontent.com/botpress/docs/master/files-openapi.json"
curl -sL -o runtime-openapi.json "https://raw.githubusercontent.com/botpress/docs/master/runtime-openapi.json"
curl -sL -o tables-openapi.json "https://raw.githubusercontent.com/botpress/docs/master/tables-openapi.json"

# Merge all specs into one using Python
python3 merge_specs.py

# Clean up individual specs
rm -f admin-openapi.json chat-openapi.json files-openapi.json runtime-openapi.json tables-openapi.json

autosdk generate openapi.json \
  --namespace Botpress \
  --clientClassName BotpressClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
