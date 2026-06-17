#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class AdminAdminListBotsCommandApiCommand
{
    private static Option<bool?> Dev { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--dev",
        description: @"If true, only dev bots are returned. Otherwise, only production bots are returned.");

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"Filter by tags",
    };

    private static Option<string?> NextToken { get; } = new(
        name: @"--next-token")
    {
        Description = @"Provide the `meta.nextToken` value provided in the last API response to retrieve the next page of results",
    };

    private static Option<global::Botpress.AdminListBotsSortField?> SortField { get; } = new(
        name: @"--sort-field")
    {
        Description = @"Sort results by this field",
    };

    private static Option<global::Botpress.AdminListBotsSortDirection?> SortDirection { get; } = new(
        name: @"--sort-direction")
    {
        Description = @"Sort results in this direction",
    };

    private static Option<string> XWorkspaceId { get; } = new(
        name: @"--x-workspace-id")
    {
        Description = @"Workspace ID",
        Required = true,
    };

    private static Option<string?> XMultipleIntegrations { get; } = new(
        name: @"--x-multiple-integrations")
    {
        Description = @"Whether the client supports bots with multiple instances of the same integration. Set to ""true"" to receive integration instances keyed by their alias instead of their id. This header will be removed in the future, and the API will always return multiple instances keyed by alias.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-bots", @"List bots");
                        command.Options.Add(Dev);
                        command.Options.Add(Tags);
                        command.Options.Add(NextToken);
                        command.Options.Add(SortField);
                        command.Options.Add(SortDirection);
                        command.Options.Add(XWorkspaceId);
                        command.Options.Add(XMultipleIntegrations);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var dev = parseResult.GetValue(Dev);
                        var tags = parseResult.GetValue(Tags);
                        var nextToken = parseResult.GetValue(NextToken);
                        var sortField = parseResult.GetValue(SortField);
                        var sortDirection = parseResult.GetValue(SortDirection);
                        var xWorkspaceId = parseResult.GetRequiredValue(XWorkspaceId);
                        var xMultipleIntegrations = parseResult.GetValue(XMultipleIntegrations);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Admin.AdminListBotsAsync(
                                    dev: dev,
                                    tags: tags,
                                    nextToken: nextToken,
                                    sortField: sortField,
                                    sortDirection: sortDirection,
                                    xWorkspaceId: xWorkspaceId,
                                    xMultipleIntegrations: xMultipleIntegrations,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}