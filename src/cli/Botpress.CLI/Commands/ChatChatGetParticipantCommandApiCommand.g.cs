#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class ChatChatGetParticipantCommandApiCommand
{
    private static Argument<string> ConversationId { get; } = new(
        name: @"conversation-id")
    {
        Description = @"Conversation id",
    };

    private static Argument<string> UserId { get; } = new(
        name: @"user-id")
    {
        Description = @"User id",
    };

    private static Option<string> XUserKey { get; } = new(
        name: @"--x-user-key")
    {
        Description = @"Authentication Key",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Botpress.ChatGetParticipantResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Botpress.ChatGetParticipantResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-participant", @"Get Participant
Retrieves a [Participant](#schema_user) from a [Conversation](#schema_conversation).");
                        command.Arguments.Add(ConversationId);
                        command.Arguments.Add(UserId);
                        command.Options.Add(XUserKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var conversationId = parseResult.GetRequiredValue(ConversationId);
                        var userId = parseResult.GetRequiredValue(UserId);
                        var xUserKey = parseResult.GetRequiredValue(XUserKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Chat.ChatGetParticipantAsync(
                                    conversationId: conversationId,
                                    userId: userId,
                                    xUserKey: xUserKey,
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