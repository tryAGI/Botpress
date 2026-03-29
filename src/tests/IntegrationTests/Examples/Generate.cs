/*
order: 10
title: Getting Started
slug: getting-started

Basic example showing how to create a client and authenticate with the Botpress API.
*/

namespace Botpress.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GettingStarted()
    {
        //// Create a Botpress client with your Personal Access Token (PAT)
        using var client = GetAuthenticatedClient();

        //// The client provides access to Admin, Chat, Files, Runtime, and Tables sub-clients
        var admin = client.Admin;
        var runtime = client.Runtime;
        var files = client.Files;
        var tables = client.Tables;
    }
}
