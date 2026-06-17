#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class RuntimeRuntimeListTagValuesCommandApiCommand
{
    private static Argument<string> Key { get; } = new(
        name: @"key")
    {
        Description = @"Tag key",
    };

    private static Option<string?> NextToken { get; } = new(
        name: @"--next-token")
    {
        Description = @"Provide the `meta.nextToken` value provided in the last API response to retrieve the next page of results",
    };

    private static Option<global::Botpress.RuntimeListTagValuesType> Type { get; } = new(
        name: @"--type")
    {
        Description = @"Tag type",
        Required = true,
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
        var command = new Command(@"list-tag-values", @"Get a bot tag values");
                        command.Arguments.Add(Key);
                        command.Options.Add(NextToken);
                        command.Options.Add(Type);
                        command.Options.Add(XBotId);
                        command.Options.Add(XIntegrationId);
                        command.Options.Add(XIntegrationAlias);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var key = parseResult.GetRequiredValue(Key);
                        var nextToken = parseResult.GetValue(NextToken);
                        var type = parseResult.GetRequiredValue(Type);
                        var xBotId = parseResult.GetRequiredValue(XBotId);
                        var xIntegrationId = parseResult.GetValue(XIntegrationId);
                        var xIntegrationAlias = parseResult.GetValue(XIntegrationAlias);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Runtime.RuntimeListTagValuesAsync(
                                    key: key,
                                    nextToken: nextToken,
                                    type: type,
                                    xBotId: xBotId,
                                    xIntegrationId: xIntegrationId,
                                    xIntegrationAlias: xIntegrationAlias,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}