#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class RuntimeRuntimePatchStateCommandApiCommand
{
    private static Argument<global::Botpress.RuntimePatchStateType> Type { get; } = new(
        name: @"type")
    {
        Description = @"Represents the resource type that the state is related to",
    };

    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"Id of the State which will be either the botId, the userId or the conversationId",
    };

    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"Name of the State which is declared inside the bot definition",
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
        var command = new Command(@"patch-state", @"Updates the [State](#schema_state) object by setting the values of the parameters passed.");
                        command.Arguments.Add(Type);
                        command.Arguments.Add(Id);
                        command.Arguments.Add(NameOption);
                        command.Options.Add(XBotId);
                        command.Options.Add(XIntegrationId);
                        command.Options.Add(XIntegrationAlias);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var type = parseResult.GetRequiredValue(Type);
                        var id = parseResult.GetRequiredValue(Id);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var xBotId = parseResult.GetRequiredValue(XBotId);
                        var xIntegrationId = parseResult.GetValue(XIntegrationId);
                        var xIntegrationAlias = parseResult.GetValue(XIntegrationAlias);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Runtime.RuntimePatchStateAsync(
                                    type: type,
                                    id: id,
                                    name: name,
                                    xBotId: xBotId,
                                    xIntegrationId: xIntegrationId,
                                    xIntegrationAlias: xIntegrationAlias,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}