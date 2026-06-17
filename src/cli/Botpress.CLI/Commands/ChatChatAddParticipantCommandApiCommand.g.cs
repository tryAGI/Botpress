#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class ChatChatAddParticipantCommandApiCommand
{
    private static Argument<string> ConversationId { get; } = new(
        name: @"conversation-id")
    {
        Description = @"Conversation id",
    };

    private static Option<string> XUserKey { get; } = new(
        name: @"--x-user-key")
    {
        Description = @"Authentication Key",
        Required = true,
    };

    private static Option<string> UserId { get; } = new(
        name: @"--user-id")
    {
        Description = @"User id",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Botpress.ChatAddParticipantResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Botpress.ChatAddParticipantResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"add-participant", @"Add Participant
Add a [Participant](#schema_user) to a [Conversation](#schema_conversation).");
                        command.Arguments.Add(ConversationId);
                        command.Options.Add(XUserKey);
                        command.Options.Add(UserId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var conversationId = parseResult.GetRequiredValue(ConversationId);
                        var xUserKey = parseResult.GetRequiredValue(XUserKey);
                        var userId = parseResult.GetRequiredValue(UserId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Chat.ChatAddParticipantAsync(
                                    conversationId: conversationId,
                                    xUserKey: xUserKey,
                                    userId: userId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Botpress.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}