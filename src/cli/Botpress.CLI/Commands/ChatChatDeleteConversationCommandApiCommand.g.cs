#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class ChatChatDeleteConversationCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"Conversation id",
    };

    private static Option<string> XUserKey { get; } = new(
        name: @"--x-user-key")
    {
        Description = @"Authentication Key",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Botpress.ChatDeleteConversationResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Botpress.ChatDeleteConversationResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"delete-conversation", @"Delete Conversation
Permanently deletes a [Conversation](#schema_conversation). It cannot be undone. Also immediately deletes corresponding [Messages](#schema_message).");
                        command.Arguments.Add(Id);
                        command.Options.Add(XUserKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var xUserKey = parseResult.GetRequiredValue(XUserKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Chat.ChatDeleteConversationAsync(
                                    id: id,
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