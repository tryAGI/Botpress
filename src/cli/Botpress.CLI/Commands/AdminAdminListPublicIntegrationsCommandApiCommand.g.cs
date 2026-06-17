#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class AdminAdminListPublicIntegrationsCommandApiCommand
{
    private static Option<string?> NextToken { get; } = new(
        name: @"--next-token")
    {
        Description = @"Provide the `meta.nextToken` value provided in the last API response to retrieve the next page of results",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of results to return per page",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Integration Name",
    };

    private static Option<string?> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Integration version. Either a semver version or tag ""latest""",
    };

    private static Option<string?> InterfaceId { get; } = new(
        name: @"--interface-id")
    {
        Description = @"Filter integrations by implemented interface ID",
    };

    private static Option<string?> InterfaceName { get; } = new(
        name: @"--interface-name")
    {
        Description = @"Filter integrations by implemented interface name (strict match)",
    };

    private static Option<string?> InstalledByBotId { get; } = new(
        name: @"--installed-by-bot-id")
    {
        Description = @"Bot ID. Required when filtering for installed integrations",
    };

    private static Option<global::Botpress.AdminListPublicIntegrationsVerificationStatus?> VerificationStatus { get; } = new(
        name: @"--verification-status")
    {
        Description = @"Filter integrations by verification status",
    };

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Search integrations by name, description, actions, and interfaces. Responses include a matchedOn field indicating which fields matched the search.",
    };

    private static Option<global::Botpress.AdminListPublicIntegrationsSortBy?> SortBy { get; } = new(
        name: @"--sort-by")
    {
        Description = @"Sort integrations by field",
    };

    private static Option<global::Botpress.AdminListPublicIntegrationsDirection?> Direction { get; } = new(
        name: @"--direction")
    {
        Description = @"Sort direction (asc or desc)",
    };

    private static Option<string?> XMultipleIntegrations { get; } = new(
        name: @"--x-multiple-integrations")
    {
        Description = @"Whether the client supports bots with multiple instances of the same integration. Set to ""true"" to receive integration instances keyed by their alias instead of their id. This header will be removed in the future, and the API will always return multiple instances keyed by alias.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-public-integrations", @"List public integration");
                        command.Options.Add(NextToken);
                        command.Options.Add(Limit);
                        command.Options.Add(NameOption);
                        command.Options.Add(Version);
                        command.Options.Add(InterfaceId);
                        command.Options.Add(InterfaceName);
                        command.Options.Add(InstalledByBotId);
                        command.Options.Add(VerificationStatus);
                        command.Options.Add(Search);
                        command.Options.Add(SortBy);
                        command.Options.Add(Direction);
                        command.Options.Add(XMultipleIntegrations);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var nextToken = parseResult.GetValue(NextToken);
                        var limit = parseResult.GetValue(Limit);
                        var name = parseResult.GetValue(NameOption);
                        var version = parseResult.GetValue(Version);
                        var interfaceId = parseResult.GetValue(InterfaceId);
                        var interfaceName = parseResult.GetValue(InterfaceName);
                        var installedByBotId = parseResult.GetValue(InstalledByBotId);
                        var verificationStatus = parseResult.GetValue(VerificationStatus);
                        var search = parseResult.GetValue(Search);
                        var sortBy = parseResult.GetValue(SortBy);
                        var direction = parseResult.GetValue(Direction);
                        var xMultipleIntegrations = parseResult.GetValue(XMultipleIntegrations);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Admin.AdminListPublicIntegrationsAsync(
                                    nextToken: nextToken,
                                    limit: limit,
                                    name: name,
                                    version: version,
                                    interfaceId: interfaceId,
                                    interfaceName: interfaceName,
                                    installedByBotId: installedByBotId,
                                    verificationStatus: verificationStatus,
                                    search: search,
                                    sortBy: sortBy,
                                    direction: direction,
                                    xMultipleIntegrations: xMultipleIntegrations,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}