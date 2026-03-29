# CLAUDE.md -- Botpress SDK

## Overview

Auto-generated C# SDK for [Botpress](https://botpress.com/) -- AI chatbot and agent platform covering Admin, Chat, Files, Runtime, and Tables APIs.
Botpress has 5 separate OpenAPI specs merged into one for generation.

## Build & Test

```bash
dotnet build Botpress.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (Personal Access Token from Botpress Cloud profile settings):

```csharp
var client = new BotpressClient(apiKey); // BOTPRESS_API_KEY or BOTPRESS_PAT env var
```

Most Admin API calls require an `x-workspace-id` header. Runtime API calls require an `x-bot-id` header.

## Key Files

- `src/libs/Botpress/openapi.json` -- Merged OpenAPI spec (generated from 5 upstream specs)
- `src/libs/Botpress/merge_specs.py` -- Python script that merges admin/chat/files/runtime/tables specs
- `src/libs/Botpress/generate.sh` -- Downloads all 5 specs, merges them, runs autosdk
- `src/libs/Botpress/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Botpress/Extensions/BotpressClient.Tools.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-Clients

The generated client uses sub-client accessors:

- `client.Admin.*` -- Bot, workspace, integration, and account management (82 endpoints)
- `client.Chat.*` -- Conversations, messages, users, events, participants (14 endpoints)
- `client.Files.*` -- File management, knowledge bases, passages, tags (9 endpoints)
- `client.Runtime.*` -- Bot runtime: conversations, messages, users, states, workflows (27 endpoints)
- `client.Tables.*` -- Table and row CRUD, find, import/export (12 endpoints)

## Spec Architecture

Botpress publishes 5 separate OpenAPI 3.0.0 specs (no single unified spec):

| Spec | Base URL | Source |
|------|----------|--------|
| Admin | `https://api.botpress.cloud` | `botpress/docs/admin-openapi.json` |
| Chat | `https://chat.botpress.cloud` | `botpress/docs/chat-openapi.json` |
| Files | `https://api.botpress.cloud` | `botpress/docs/files-openapi.json` |
| Runtime | `https://api.botpress.cloud` | `botpress/docs/runtime-openapi.json` |
| Tables | `https://api.botpress.cloud` | `botpress/docs/tables-openapi.json` |

The `merge_specs.py` script merges them into a single `openapi.json` with prefixed schema names (e.g., `AdminBot`, `RuntimeMessage`) and unique operation IDs (e.g., `Admin_listBots`, `Runtime_createMessage`).

## Response Bodies

The upstream Botpress OpenAPI specs do **not** define response body schemas -- all responses have `200: {}` with no `content` type. As a result, generated methods return `Task` (void). The API actually returns JSON -- the tools implementation uses raw `HttpClient` calls to capture response JSON.

## MEAI AIFunction Tools

| Tool | Description |
|------|-------------|
| `AsListBotsTool(workspaceId)` | Lists all bots in a workspace |
| `AsGetBotTool(workspaceId)` | Gets details of a specific bot |
| `AsListConversationsTool(botId)` | Lists conversations for a bot |
| `AsListMessagesTool(botId)` | Lists messages in a conversation |
| `AsGetBotAnalyticsTool(workspaceId)` | Gets analytics data for a bot |

## Environment Variables for Tests

| Variable | Required | Description |
|----------|----------|-------------|
| `BOTPRESS_API_KEY` or `BOTPRESS_PAT` | Yes | Personal Access Token |
| `BOTPRESS_WORKSPACE_ID` | For admin tests | Workspace ID |
| `BOTPRESS_BOT_ID` | For runtime tests | Bot ID |
| `BOTPRESS_CONVERSATION_ID` | For message tests | Conversation ID |
