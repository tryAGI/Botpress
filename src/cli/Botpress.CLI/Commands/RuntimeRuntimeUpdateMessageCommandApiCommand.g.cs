#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class RuntimeRuntimeUpdateMessageCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"Message id",
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
        var command = new Command(@"update-message", @"Updates a message tags and payload. The message type cannot be changed. Calling this operation from an integration, to update an incoming message, will not invoke the bot. The other way around it also true; Calling this operation from the bot, to update an outgoing message, will not invoke the integration.");
                        command.Arguments.Add(Id);
                        command.Options.Add(XBotId);
                        command.Options.Add(XIntegrationId);
                        command.Options.Add(XIntegrationAlias);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var xBotId = parseResult.GetRequiredValue(XBotId);
                        var xIntegrationId = parseResult.GetValue(XIntegrationId);
                        var xIntegrationAlias = parseResult.GetValue(XIntegrationAlias);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Runtime.RuntimeUpdateMessageAsync(
                                    id: id,
                                    xBotId: xBotId,
                                    xIntegrationId: xIntegrationId,
                                    xIntegrationAlias: xIntegrationAlias,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}