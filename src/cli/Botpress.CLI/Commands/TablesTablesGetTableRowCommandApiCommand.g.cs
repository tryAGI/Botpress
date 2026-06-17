#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class TablesTablesGetTableRowCommandApiCommand
{
    private static Argument<string> Table { get; } = new(
        name: @"table")
    {
        Description = @"The table's name or unique identifier for targeting specific table operations.",
    };

    private static Option<int> Id { get; } = new(
        name: @"--id")
    {
        Description = @"Identifier of the row within the table.",
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

    private static Option<string?> XIntegrationName { get; } = new(
        name: @"--x-integration-name")
    {
        Description = @"Integration name",
    };

    private static Option<string?> XUserId { get; } = new(
        name: @"--x-user-id")
    {
        Description = @"User Id",
    };

    private static Option<string?> XUserRole { get; } = new(
        name: @"--x-user-role")
    {
        Description = @"User Role",
    };

    public static Command Create()
    {
        var command = new Command(@"get-table-row", @"Fetches a specific row from a table using the row's unique identifier.");
                        command.Arguments.Add(Table);
                        command.Options.Add(Id);
                        command.Options.Add(XBotId);
                        command.Options.Add(XIntegrationId);
                        command.Options.Add(XIntegrationAlias);
                        command.Options.Add(XIntegrationName);
                        command.Options.Add(XUserId);
                        command.Options.Add(XUserRole);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var table = parseResult.GetRequiredValue(Table);
                        var id = parseResult.GetRequiredValue(Id);
                        var xBotId = parseResult.GetRequiredValue(XBotId);
                        var xIntegrationId = parseResult.GetValue(XIntegrationId);
                        var xIntegrationAlias = parseResult.GetValue(XIntegrationAlias);
                        var xIntegrationName = parseResult.GetValue(XIntegrationName);
                        var xUserId = parseResult.GetValue(XUserId);
                        var xUserRole = parseResult.GetValue(XUserRole);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Tables.TablesGetTableRowAsync(
                                    table: table,
                                    id: id,
                                    xBotId: xBotId,
                                    xIntegrationId: xIntegrationId,
                                    xIntegrationAlias: xIntegrationAlias,
                                    xIntegrationName: xIntegrationName,
                                    xUserId: xUserId,
                                    xUserRole: xUserRole,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}