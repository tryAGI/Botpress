/*
order: 50
title: Tables
slug: tables

Example showing how to work with tables for structured data storage.
*/

namespace Botpress.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListTables()
    {
        //// Create a Botpress client and list tables
        using var client = GetAuthenticatedClient();
        var botId = GetBotId();

        //// List all tables associated with the bot
        await client.Tables.TablesListTablesAsync(
            xBotId: botId);
    }
}
