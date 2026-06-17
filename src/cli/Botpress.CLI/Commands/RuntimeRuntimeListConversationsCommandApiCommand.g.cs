#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class RuntimeRuntimeListConversationsCommandApiCommand
{
    private static Option<string?> NextToken { get; } = new(
        name: @"--next-token")
    {
        Description = @"Provide the `meta.nextToken` value provided in the last API response to retrieve the next page of results",
    };

    private static Option<global::Botpress.RuntimeListConversationsSortField?> SortField { get; } = new(
        name: @"--sort-field")
    {
        Description = @"Sort results by this field",
    };

    private static Option<global::Botpress.RuntimeListConversationsSortDirection?> SortDirection { get; } = new(
        name: @"--sort-direction")
    {
        Description = @"Sort results in this direction",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"Filter by tags",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ParticipantIds { get; } = new(
        name: @"--participant-ids")
    {
        Description = @"Filter by participant ids",
    };

    private static Option<string?> IntegrationName { get; } = new(
        name: @"--integration-name")
    {
        Description = @"Filter by integration name",
    };

    private static Option<string?> Channel { get; } = new(
        name: @"--channel")
    {
        Description = @"Filter by integration channel name",
    };

    private static Option<string?> AfterDate { get; } = new(
        name: @"--after-date")
    {
        Description = @"Date in ISO 8601 string with UTC timezone after which the conversation was created (inclusive)",
    };

    private static Option<string?> BeforeDate { get; } = new(
        name: @"--before-date")
    {
        Description = @"Date in ISO 8601 string with UTC timezone before which the conversation was created (inclusive)",
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
        var command = new Command(@"list-conversations", @"Retrieves a list of [Conversation](#schema_conversation) you’ve previously created. The conversations are returned in sorted order, with the most recent appearing first. The list can be filtered using [Tags](#tags).");
                        command.Options.Add(NextToken);
                        command.Options.Add(SortField);
                        command.Options.Add(SortDirection);
                        command.Options.Add(Tags);
                        command.Options.Add(ParticipantIds);
                        command.Options.Add(IntegrationName);
                        command.Options.Add(Channel);
                        command.Options.Add(AfterDate);
                        command.Options.Add(BeforeDate);
                        command.Options.Add(XBotId);
                        command.Options.Add(XIntegrationId);
                        command.Options.Add(XIntegrationAlias);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var nextToken = parseResult.GetValue(NextToken);
                        var sortField = parseResult.GetValue(SortField);
                        var sortDirection = parseResult.GetValue(SortDirection);
                        var tags = parseResult.GetValue(Tags);
                        var participantIds = parseResult.GetValue(ParticipantIds);
                        var integrationName = parseResult.GetValue(IntegrationName);
                        var channel = parseResult.GetValue(Channel);
                        var afterDate = parseResult.GetValue(AfterDate);
                        var beforeDate = parseResult.GetValue(BeforeDate);
                        var xBotId = parseResult.GetRequiredValue(XBotId);
                        var xIntegrationId = parseResult.GetValue(XIntegrationId);
                        var xIntegrationAlias = parseResult.GetValue(XIntegrationAlias);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Runtime.RuntimeListConversationsAsync(
                                    nextToken: nextToken,
                                    sortField: sortField,
                                    sortDirection: sortDirection,
                                    tags: tags,
                                    participantIds: participantIds,
                                    integrationName: integrationName,
                                    channel: channel,
                                    afterDate: afterDate,
                                    beforeDate: beforeDate,
                                    xBotId: xBotId,
                                    xIntegrationId: xIntegrationId,
                                    xIntegrationAlias: xIntegrationAlias,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}