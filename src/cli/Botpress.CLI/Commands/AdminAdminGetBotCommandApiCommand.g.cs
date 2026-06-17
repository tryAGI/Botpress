#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class AdminAdminGetBotCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"Bot ID",
    };

    private static Option<bool?> ShouldMergePlugins { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--should-merge-plugins",
        description: @"UNUSED. Please ignore this field. It will be removed in the near future.");

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
        var command = new Command(@"get-bot", @"Get bot details");
                        command.Arguments.Add(Id);
                        command.Options.Add(ShouldMergePlugins);
                        command.Options.Add(XWorkspaceId);
                        command.Options.Add(XMultipleIntegrations);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var shouldMergePlugins = parseResult.GetValue(ShouldMergePlugins);
                        var xWorkspaceId = parseResult.GetRequiredValue(XWorkspaceId);
                        var xMultipleIntegrations = parseResult.GetValue(XMultipleIntegrations);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Admin.AdminGetBotAsync(
                                    id: id,
                                    shouldMergePlugins: shouldMergePlugins,
                                    xWorkspaceId: xWorkspaceId,
                                    xMultipleIntegrations: xMultipleIntegrations,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}