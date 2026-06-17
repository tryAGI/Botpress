#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class ChatChatCreateMessageCommandApiCommand
{
    private static Option<string> XUserKey { get; } = new(
        name: @"--x-user-key")
    {
        Description = @"Authentication Key",
        Required = true,
    };

    private static Option<global::Botpress.OneOf<global::Botpress.ChatCreateMessageRequestPayloadAudio, global::Botpress.ChatCreateMessageRequestPayloadCard, global::Botpress.ChatCreateMessageRequestPayloadCarousel, global::Botpress.ChatCreateMessageRequestPayloadChoice, global::Botpress.ChatCreateMessageRequestPayloadDropdown, global::Botpress.ChatCreateMessageRequestPayloadFile, global::Botpress.ChatCreateMessageRequestPayloadImage, global::Botpress.ChatCreateMessageRequestPayloadLocation, global::Botpress.ChatCreateMessageRequestPayloadMarkdown, global::Botpress.ChatCreateMessageRequestPayloadText, global::Botpress.ChatCreateMessageRequestPayloadVideo>> Payload { get; } = new(
        name: @"--payload")
    {
        Description = @"Payload is the content type of the message.",
        Required = true,
    };

    private static Option<string> ConversationId { get; } = new(
        name: @"--conversation-id")
    {
        Description = @"ID of the [Conversation](#schema_conversation)",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Botpress.ChatCreateMessageResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Botpress.ChatCreateMessageResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-message", @"Create Message
Creates a new [Message](#schema_message)");
                        command.Options.Add(XUserKey);
                        command.Options.Add(Payload);
                        command.Options.Add(ConversationId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var xUserKey = parseResult.GetRequiredValue(XUserKey);
                        var payload = parseResult.GetRequiredValue(Payload);
                        var conversationId = parseResult.GetRequiredValue(ConversationId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Chat.ChatCreateMessageAsync(
                                    xUserKey: xUserKey,
                                    payload: payload,
                                    conversationId: conversationId,
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