/*
order: 20
title: List Bots
slug: list-bots

Example showing how to list bots in a workspace using the Admin API.
*/

namespace Botpress.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListBots()
    {
        //// Create a Botpress client and list bots in the workspace
        using var client = GetAuthenticatedClient();
        var workspaceId = GetWorkspaceId();

        //// List all bots in the workspace
        await client.Admin.AdminListBotsAsync(
            xWorkspaceId: workspaceId);
    }
}
