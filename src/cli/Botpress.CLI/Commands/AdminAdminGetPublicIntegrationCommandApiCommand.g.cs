#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class AdminAdminGetPublicIntegrationCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"Integration Name",
    };

    private static Argument<string> Version { get; } = new(
        name: @"version")
    {
        Description = @"Integration version. Either a semver version, semver version range, or the constant string ""latest""",
    };

    private static Option<string?> XMultipleIntegrations { get; } = new(
        name: @"--x-multiple-integrations")
    {
        Description = @"Whether the client supports bots with multiple instances of the same integration. Set to ""true"" to receive integration instances keyed by their alias instead of their id. This header will be removed in the future, and the API will always return multiple instances keyed by alias.",
    };

    public static Command Create()
    {
        var command = new Command(@"get-public-integration", @"Get public integration by name and version");
                        command.Arguments.Add(NameOption);
                        command.Arguments.Add(Version);
                        command.Options.Add(XMultipleIntegrations);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var name = parseResult.GetRequiredValue(NameOption);
                        var version = parseResult.GetRequiredValue(Version);
                        var xMultipleIntegrations = parseResult.GetValue(XMultipleIntegrations);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Admin.AdminGetPublicIntegrationAsync(
                                    name: name,
                                    version: version,
                                    xMultipleIntegrations: xMultipleIntegrations,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}