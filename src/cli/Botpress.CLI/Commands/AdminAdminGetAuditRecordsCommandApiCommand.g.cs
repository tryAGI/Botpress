#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class AdminAdminGetAuditRecordsCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"Workspace ID",
    };

    private static Option<string?> NextToken { get; } = new(
        name: @"--next-token")
    {
        Description = @"Provide the `meta.nextToken` value provided in the last API response to retrieve the next page of results",
    };

    private static Option<string?> XMultipleIntegrations { get; } = new(
        name: @"--x-multiple-integrations")
    {
        Description = @"Whether the client supports bots with multiple instances of the same integration. Set to ""true"" to receive integration instances keyed by their alias instead of their id. This header will be removed in the future, and the API will always return multiple instances keyed by alias.",
    };

    public static Command Create()
    {
        var command = new Command(@"get-audit-records", @"Get the audit records of a workspace, sorted from most recent to oldest.");
                        command.Arguments.Add(Id);
                        command.Options.Add(NextToken);
                        command.Options.Add(XMultipleIntegrations);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var nextToken = parseResult.GetValue(NextToken);
                        var xMultipleIntegrations = parseResult.GetValue(XMultipleIntegrations);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Admin.AdminGetAuditRecordsAsync(
                                    id: id,
                                    nextToken: nextToken,
                                    xMultipleIntegrations: xMultipleIntegrations,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}