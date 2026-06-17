#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class RuntimeRuntimeListMessagesCommandApiCommand
{
    private static Option<string?> NextToken { get; } = new(
        name: @"--next-token")
    {
        Description = @"Provide the `meta.nextToken` value provided in the last API response to retrieve the next page of results",
    };

    private static Option<string?> ConversationId { get; } = new(
        name: @"--conversation-id")
    {
        Description = @"Conversation id",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"Filter by tags",
    };

    private static Option<string?> AfterDate { get; } = new(
        name: @"--after-date")
    {
        Description = @"Date in ISO 8601 string with UTC timezone after which the message was created (inclusive)",
    };

    private static Option<string?> BeforeDate { get; } = new(
        name: @"--before-date")
    {
        Description = @"Date in ISO 8601 string with UTC timezone before which the message was created (inclusive)",
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
        var command = new Command(@"list-messages", @"Retrieves a list of [Message](#schema_message) you’ve previously created. The messages are returned in sorted order, with the most recent appearing first. The list can be filtered using [Tags](/docs/developers/concepts/tags).");
                        command.Options.Add(NextToken);
                        command.Options.Add(ConversationId);
                        command.Options.Add(Tags);
                        command.Options.Add(AfterDate);
                        command.Options.Add(BeforeDate);
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
                        var xBotId = parseResult.GetRequiredValue(XBotId);
                        var xIntegrationId = parseResult.GetValue(XIntegrationId);
                        var xIntegrationAlias = parseResult.GetValue(XIntegrationAlias);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Runtime.RuntimeListMessagesAsync(
                                    nextToken: nextToken,
                                    conversationId: conversationId,
                                    tags: tags,
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