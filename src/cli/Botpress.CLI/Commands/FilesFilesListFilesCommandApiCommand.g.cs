#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class FilesFilesListFilesCommandApiCommand
{
    private static Option<string?> NextToken { get; } = new(
        name: @"--next-token")
    {
        Description = @"Provide the `meta.nextToken` value provided in the last API response to retrieve the next page of results",
    };

    private static Option<global::Botpress.FilesListFilesSortField?> SortField { get; } = new(
        name: @"--sort-field")
    {
        Description = @"Sort results by this field",
    };

    private static Option<global::Botpress.FilesListFilesSortDirection?> SortDirection { get; } = new(
        name: @"--sort-direction")
    {
        Description = @"Sort results in this direction",
    };

    private static Option<object?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"Filter files by tags. Tags should be passed as a URL-encoded JSON object of key-value pairs that must be present in the tags of a file. An array of multiple string values for the same key are treated as an OR condition. To exclude a value, express it as an object with a nested `not` key with the string or string-array value(s) to exclude.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Ids { get; } = new(
        name: @"--ids")
    {
        Description = @"Filter files by IDs.",
    };

    private static Option<bool?> Indexed { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--indexed",
        description: @"Filter files by indexing state");

    private static Option<string> XBotId { get; } = new(
        name: @"--x-bot-id")
    {
        Description = @"Bot id",
        Required = true,
    };

    private static Option<string?> XIntegrationId { get; } = new(
        name: @"--x-integration-id")
    {
        Description = @"Integration id",
    };

    private static Option<string?> XIntegrationAlias { get; } = new(
        name: @"--x-integration-alias")
    {
        Description = @"Integration alias",
    };

    private static Option<string?> XIntegrationName { get; } = new(
        name: @"--x-integration-name")
    {
        Description = @"Integration name",
    };

    private static Option<string?> XUserId { get; } = new(
        name: @"--x-user-id")
    {
        Description = @"User Id",
    };

    private static Option<string?> XUserRole { get; } = new(
        name: @"--x-user-role")
    {
        Description = @"User Role",
    };

    public static Command Create()
    {
        var command = new Command(@"list-files", @"List files for bot");
                        command.Options.Add(NextToken);
                        command.Options.Add(SortField);
                        command.Options.Add(SortDirection);
                        command.Options.Add(Tags);
                        command.Options.Add(Ids);
                        command.Options.Add(Indexed);
                        command.Options.Add(XBotId);
                        command.Options.Add(XIntegrationId);
                        command.Options.Add(XIntegrationAlias);
                        command.Options.Add(XIntegrationName);
                        command.Options.Add(XUserId);
                        command.Options.Add(XUserRole);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var nextToken = parseResult.GetValue(NextToken);
                        var sortField = parseResult.GetValue(SortField);
                        var sortDirection = parseResult.GetValue(SortDirection);
                        var tags = parseResult.GetValue(Tags);
                        var ids = parseResult.GetValue(Ids);
                        var indexed = parseResult.GetValue(Indexed);
                        var xBotId = parseResult.GetRequiredValue(XBotId);
                        var xIntegrationId = parseResult.GetValue(XIntegrationId);
                        var xIntegrationAlias = parseResult.GetValue(XIntegrationAlias);
                        var xIntegrationName = parseResult.GetValue(XIntegrationName);
                        var xUserId = parseResult.GetValue(XUserId);
                        var xUserRole = parseResult.GetValue(XUserRole);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Files.FilesListFilesAsync(
                                    nextToken: nextToken,
                                    sortField: sortField,
                                    sortDirection: sortDirection,
                                    tags: tags,
                                    ids: ids,
                                    indexed: indexed,
                                    xBotId: xBotId,
                                    xIntegrationId: xIntegrationId,
                                    xIntegrationAlias: xIntegrationAlias,
                                    xIntegrationName: xIntegrationName,
                                    xUserId: xUserId,
                                    xUserRole: xUserRole,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}