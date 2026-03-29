# Botpress

[![Nuget package](https://img.shields.io/nuget/vpre/Botpress)](https://www.nuget.org/packages/Botpress/)
[![dotnet](https://github.com/tryAGI/Botpress/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Botpress/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Botpress)](https://github.com/tryAGI/Botpress/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features
- Fully generated C# SDK based on [official Botpress OpenAPI specifications](https://github.com/botpress/docs) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Covers all 5 Botpress APIs: Admin, Chat, Files, Runtime, and Tables (144 endpoints)
- MEAI `AIFunction` tools for use with any `IChatClient`
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.

### Usage
```csharp
using Botpress;

// Authenticate with a Personal Access Token
using var client = new BotpressClient(apiKey);

// Admin API - list bots in a workspace
await client.Admin.AdminListBotsAsync(xWorkspaceId: "your-workspace-id");

// Runtime API - list conversations for a bot
await client.Runtime.RuntimeListConversationsAsync(xBotId: "your-bot-id");

// Tables API - list tables
await client.Tables.TablesListTablesAsync(xBotId: "your-bot-id");
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Botpress/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Botpress/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
