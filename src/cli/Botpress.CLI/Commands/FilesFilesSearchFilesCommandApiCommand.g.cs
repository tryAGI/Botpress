#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class FilesFilesSearchFilesCommandApiCommand
{
    private static Option<object?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"Filter files by tags. Tags should be passed as a URL-encoded JSON object of key-value pairs that must be present in the tags of a file. An array of multiple string values for the same key are treated as an OR condition. To exclude a value, express it as an object with a nested `not` key with the string or string-array value(s) to exclude.",
    };

    private static Option<string> Query { get; } = new(
        name: @"--query")
    {
        Description = @"Query expressed in natural language to retrieve matching text passages within all indexed files in the bot using semantical search.",
        Required = true,
    };

    private static Option<int?> ContextDepth { get; } = new(
        name: @"--context-depth")
    {
        Description = @"The number of neighbor passages to prepend and append as surrounding context to the content of each returned passage (default: 1, minimum: 0, maximum: 10).",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"The maximum number of passages to return.",
    };

    private static Option<bool?> Consolidate { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--consolidate",
        description: @"Consolidate the results by merging matching passages from the same file into a single passage per file. The consolidated passage will include the matching passages ordered by their original position in the file (rather than by relevance score) and include hierarchical context such as the title/subtitle to which they belong.");

    private static Option<bool?> IncludeBreadcrumb { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-breadcrumb",
        description: @"Prepend a breadcrumb to each passage, containing the title and subtitle(s) the passage belongs to in the file. This option is ignored when the `consolidate` option is set to `true`.");

    private static Option<bool?> WithContext { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--with-context",
        description: @"Include the surrounding context with each passage in the `context` property of each passage. Not supported when `consolidate` is set to `true`.");

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
        var command = new Command(@"search-files", @"Search files");
                        command.Options.Add(Tags);
                        command.Options.Add(Query);
                        command.Options.Add(ContextDepth);
                        command.Options.Add(Limit);
                        command.Options.Add(Consolidate);
                        command.Options.Add(IncludeBreadcrumb);
                        command.Options.Add(WithContext);
                        command.Options.Add(XBotId);
                        command.Options.Add(XIntegrationId);
                        command.Options.Add(XIntegrationAlias);
                        command.Options.Add(XIntegrationName);
                        command.Options.Add(XUserId);
                        command.Options.Add(XUserRole);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var tags = parseResult.GetValue(Tags);
                        var query = parseResult.GetRequiredValue(Query);
                        var contextDepth = parseResult.GetValue(ContextDepth);
                        var limit = parseResult.GetValue(Limit);
                        var consolidate = parseResult.GetValue(Consolidate);
                        var includeBreadcrumb = parseResult.GetValue(IncludeBreadcrumb);
                        var withContext = parseResult.GetValue(WithContext);
                        var xBotId = parseResult.GetRequiredValue(XBotId);
                        var xIntegrationId = parseResult.GetValue(XIntegrationId);
                        var xIntegrationAlias = parseResult.GetValue(XIntegrationAlias);
                        var xIntegrationName = parseResult.GetValue(XIntegrationName);
                        var xUserId = parseResult.GetValue(XUserId);
                        var xUserRole = parseResult.GetValue(XUserRole);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Files.FilesSearchFilesAsync(
                                    tags: tags,
                                    query: query,
                                    contextDepth: contextDepth,
                                    limit: limit,
                                    consolidate: consolidate,
                                    includeBreadcrumb: includeBreadcrumb,
                                    withContext: withContext,
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