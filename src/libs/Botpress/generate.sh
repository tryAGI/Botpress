#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# Botpress has 5 separate OpenAPI specs (Admin, Chat, Files, Runtime, Tables).
# We merge them into a single spec for generation.
install_autosdk_cli

rm -rf Generated

# Download all 5 specs
fetch_spec -sL -o admin-openapi.json "https://raw.githubusercontent.com/botpress/docs/master/admin-openapi.json"
fetch_spec -sL -o chat-openapi.json "https://raw.githubusercontent.com/botpress/docs/master/chat-openapi.json"
fetch_spec -sL -o files-openapi.json "https://raw.githubusercontent.com/botpress/docs/master/files-openapi.json"
fetch_spec -sL -o runtime-openapi.json "https://raw.githubusercontent.com/botpress/docs/master/runtime-openapi.json"
fetch_spec -sL -o tables-openapi.json "https://raw.githubusercontent.com/botpress/docs/master/tables-openapi.json"

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

rm -rf ../../cli/Botpress.CLI

autosdk cli-project openapi.json \
  --output ../../cli/Botpress.CLI \
  --sdk-project ../../libs/Botpress/Botpress.csproj \
  --targetFramework net10.0 \
  --namespace Botpress \
  --clientClassName BotpressClient \
  --package-id Botpress.CLI \
  --tool-command-name botpress \
  --user-secrets-id Botpress.CLI \
  --api-key-env-var BOTPRESS_API_KEY \
  --base-url-env-var BOTPRESS_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
