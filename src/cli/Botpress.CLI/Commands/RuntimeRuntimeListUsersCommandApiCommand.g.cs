#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class RuntimeRuntimeListUsersCommandApiCommand
{
    private static Option<string?> NextToken { get; } = new(
        name: @"--next-token")
    {
        Description = @"Provide the `meta.nextToken` value provided in the last API response to retrieve the next page of results",
    };

    private static Option<string?> ConversationId { get; } = new(
        name: @"--conversation-id")
    {
        Description = @"Filter by conversation id. This will return all users that have participated in the conversation.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"Filter by tags",
    };

    private static Option<string?> AfterDate { get; } = new(
        name: @"--after-date")
    {
        Description = @"Date in ISO 8601 string with UTC timezone after which the user was created or updated (inclusive)",
    };

    private static Option<string?> BeforeDate { get; } = new(
        name: @"--before-date")
    {
        Description = @"Date in ISO 8601 string with UTC timezone before which the user was created or updated (inclusive)",
    };

    private static Option<global::Botpress.RuntimeListUsersRangeField?> RangeField { get; } = new(
        name: @"--range-field")
    {
        Description = @"Field used for range filtering. Allowed values are ""updatedAt"" or ""createdAt"". Defaults to ""createdAt"" if omitted.",
    };

    private static Option<global::Botpress.RuntimeListUsersSortField?> SortField { get; } = new(
        name: @"--sort-field")
    {
        Description = @"Sort results by this field",
    };

    private static Option<global::Botpress.RuntimeListUsersSortDirection?> SortDirection { get; } = new(
        name: @"--sort-direction")
    {
        Description = @"Sort results in this direction",
    };

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

    public static Command Create()
    {
        var command = new Command(@"list-users", @"Retrieves a list of [User](#schema_user) previously created. The users are returned in sorted order, with the most recent appearing first. The list can be filtered using [Tags](/docs/developers/concepts/tags).");
                        command.Options.Add(NextToken);
                        command.Options.Add(ConversationId);
                        command.Options.Add(Tags);
                        command.Options.Add(AfterDate);
                        command.Options.Add(BeforeDate);
                        command.Options.Add(RangeField);
                        command.Options.Add(SortField);
                        command.Options.Add(SortDirection);
                        command.Options.Add(XBotId);
                        command.Options.Add(XIntegrationId);
                        command.Options.Add(XIntegrationAlias);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var nextToken = parseResult.GetValue(NextToken);
                        var conversationId = parseResult.GetValue(ConversationId);
                        var tags = parseResult.GetValue(Tags);
                        var afterDate = parseResult.GetValue(AfterDate);
                        var beforeDate = parseResult.GetValue(BeforeDate);
                        var rangeField = parseResult.GetValue(RangeField);
                        var sortField = parseResult.GetValue(SortField);
                        var sortDirection = parseResult.GetValue(SortDirection);
                        var xBotId = parseResult.GetRequiredValue(XBotId);
                        var xIntegrationId = parseResult.GetValue(XIntegrationId);
                        var xIntegrationAlias = parseResult.GetValue(XIntegrationAlias);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Runtime.RuntimeListUsersAsync(
                                    nextToken: nextToken,
                                    conversationId: conversationId,
                                    tags: tags,
                                    afterDate: afterDate,
                                    beforeDate: beforeDate,
                                    rangeField: rangeField,
                                    sortField: sortField,
                                    sortDirection: sortDirection,
                                    xBotId: xBotId,
                                    xIntegrationId: xIntegrationId,
                                    xIntegrationAlias: xIntegrationAlias,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}