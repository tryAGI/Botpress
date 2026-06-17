#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class AdminAdminListPublicWorkspacesCommandApiCommand
{
    private static Option<string?> NextToken { get; } = new(
        name: @"--next-token")
    {
        Description = @"Provide the `meta.nextToken` value provided in the last API response to retrieve the next page of results",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> WorkspaceIds { get; } = new(
        name: @"--workspace-ids")
    {
        Description = @"Ids of the workspaces to list",
    };

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Search query",
    };

    private static Option<string?> XMultipleIntegrations { get; } = new(
        name: @"--x-multiple-integrations")
    {
        Description = @"Whether the client supports bots with multiple instances of the same integration. Set to ""true"" to receive integration instances keyed by their alias instead of their id. This header will be removed in the future, and the API will always return multiple instances keyed by alias.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-public-workspaces", @"List public workspaces");
                        command.Options.Add(NextToken);
                        command.Options.Add(WorkspaceIds);
                        command.Options.Add(Search);
                        command.Options.Add(XMultipleIntegrations);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var nextToken = parseResult.GetValue(NextToken);
                        var workspaceIds = parseResult.GetValue(WorkspaceIds);
                        var search = parseResult.GetValue(Search);
                        var xMultipleIntegrations = parseResult.GetValue(XMultipleIntegrations);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Admin.AdminListPublicWorkspacesAsync(
                                    nextToken: nextToken,
                                    workspaceIds: workspaceIds,
                                    search: search,
                                    xMultipleIntegrations: xMultipleIntegrations,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}