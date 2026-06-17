#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class AdminAdminGetIntegrationLogsCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"Integration Version ID",
    };

    private static Option<string> TimeStart { get; } = new(
        name: @"--time-start")
    {
        Description = @"Beginning of the time range to get logs from",
        Required = true,
    };

    private static Option<string?> TimeEnd { get; } = new(
        name: @"--time-end")
    {
        Description = @"End of the time range to get logs from",
    };

    private static Option<string?> Level { get; } = new(
        name: @"--level")
    {
        Description = @"Filter by log level",
    };

    private static Option<string?> UserId { get; } = new(
        name: @"--user-id")
    {
        Description = @"Filter by user ID",
    };

    private static Option<string?> ConversationId { get; } = new(
        name: @"--conversation-id")
    {
        Description = @"Filter by conversation ID",
    };

    private static Option<string?> MessageContains { get; } = new(
        name: @"--message-contains")
    {
        Description = @"Filter logs where the message contains this substring",
    };

    private static Option<string?> NextToken { get; } = new(
        name: @"--next-token")
    {
        Description = @"Token to get the next page of logs",
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
        var command = new Command(@"get-integration-logs", @"Get integration logs");
                        command.Arguments.Add(Id);
                        command.Options.Add(TimeStart);
                        command.Options.Add(TimeEnd);
                        command.Options.Add(Level);
                        command.Options.Add(UserId);
                        command.Options.Add(ConversationId);
                        command.Options.Add(MessageContains);
                        command.Options.Add(NextToken);
                        command.Options.Add(XWorkspaceId);
                        command.Options.Add(XMultipleIntegrations);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var timeStart = parseResult.GetRequiredValue(TimeStart);
                        var timeEnd = parseResult.GetValue(TimeEnd);
                        var level = parseResult.GetValue(Level);
                        var userId = parseResult.GetValue(UserId);
                        var conversationId = parseResult.GetValue(ConversationId);
                        var messageContains = parseResult.GetValue(MessageContains);
                        var nextToken = parseResult.GetValue(NextToken);
                        var xWorkspaceId = parseResult.GetRequiredValue(XWorkspaceId);
                        var xMultipleIntegrations = parseResult.GetValue(XMultipleIntegrations);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Admin.AdminGetIntegrationLogsAsync(
                                    id: id,
                                    timeStart: timeStart,
                                    timeEnd: timeEnd,
                                    level: level,
                                    userId: userId,
                                    conversationId: conversationId,
                                    messageContains: messageContains,
                                    nextToken: nextToken,
                                    xWorkspaceId: xWorkspaceId,
                                    xMultipleIntegrations: xMultipleIntegrations,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}