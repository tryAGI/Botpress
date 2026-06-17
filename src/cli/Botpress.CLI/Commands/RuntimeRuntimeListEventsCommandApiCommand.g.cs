#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class RuntimeRuntimeListEventsCommandApiCommand
{
    private static Option<string?> NextToken { get; } = new(
        name: @"--next-token")
    {
        Description = @"Provide the `meta.nextToken` value provided in the last API response to retrieve the next page of results",
    };

    private static Option<string?> Type { get; } = new(
        name: @"--type")
    {
        Description = @"Filter by event type",
    };

    private static Option<string?> ConversationId { get; } = new(
        name: @"--conversation-id")
    {
        Description = @"Filter by conversation id",
    };

    private static Option<string?> UserId { get; } = new(
        name: @"--user-id")
    {
        Description = @"Filter by user id",
    };

    private static Option<string?> MessageId { get; } = new(
        name: @"--message-id")
    {
        Description = @"Filter by message id",
    };

    private static Option<string?> WorkflowId { get; } = new(
        name: @"--workflow-id")
    {
        Description = @"Filter by workflow id",
    };

    private static Option<global::Botpress.RuntimeListEventsStatus?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter by status. Allowed values: pending, ignored, processed, failed.",
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
        var command = new Command(@"list-events", @"Retrieves a list of [Event](#schema_event) you’ve previously created. The events are returned in sorted order, with the most recent appearing first.");
                        command.Options.Add(NextToken);
                        command.Options.Add(Type);
                        command.Options.Add(ConversationId);
                        command.Options.Add(UserId);
                        command.Options.Add(MessageId);
                        command.Options.Add(WorkflowId);
                        command.Options.Add(Status);
                        command.Options.Add(XBotId);
                        command.Options.Add(XIntegrationId);
                        command.Options.Add(XIntegrationAlias);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var nextToken = parseResult.GetValue(NextToken);
                        var type = parseResult.GetValue(Type);
                        var conversationId = parseResult.GetValue(ConversationId);
                        var userId = parseResult.GetValue(UserId);
                        var messageId = parseResult.GetValue(MessageId);
                        var workflowId = parseResult.GetValue(WorkflowId);
                        var status = parseResult.GetValue(Status);
                        var xBotId = parseResult.GetRequiredValue(XBotId);
                        var xIntegrationId = parseResult.GetValue(XIntegrationId);
                        var xIntegrationAlias = parseResult.GetValue(XIntegrationAlias);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Runtime.RuntimeListEventsAsync(
                                    nextToken: nextToken,
                                    type: type,
                                    conversationId: conversationId,
                                    userId: userId,
                                    messageId: messageId,
                                    workflowId: workflowId,
                                    status: status,
                                    xBotId: xBotId,
                                    xIntegrationId: xIntegrationId,
                                    xIntegrationAlias: xIntegrationAlias,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}