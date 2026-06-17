#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class RuntimeRuntimeCreateEventCommandApiCommand
{
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
        var command = new Command(@"create-event", @"Creates a new [Event](#schema_event). When creating a new [Event](#schema_event), the required tags must be provided. See the specific integration for more details.");
                        command.Options.Add(XBotId);
                        command.Options.Add(XIntegrationId);
                        command.Options.Add(XIntegrationAlias);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var xBotId = parseResult.GetRequiredValue(XBotId);
                        var xIntegrationId = parseResult.GetValue(XIntegrationId);
                        var xIntegrationAlias = parseResult.GetValue(XIntegrationAlias);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Runtime.RuntimeCreateEventAsync(
                                    xBotId: xBotId,
                                    xIntegrationId: xIntegrationId,
                                    xIntegrationAlias: xIntegrationAlias,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}