#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class FilesFilesCopyFileCommandApiCommand
{
    private static Argument<string> IdOrKey { get; } = new(
        name: @"id-or-key")
    {
        Description = @"File ID or Key",
    };

    private static Argument<string> DestinationKey { get; } = new(
        name: @"destination-key")
    {
        Description = @"The new key of the file. The file key must not be in use already in the destination bot.",
    };

    private static Option<string?> XDestinationBotId { get; } = new(
        name: @"--x-destination-bot-id")
    {
        Description = @"The bot ID to copy the file to. You must have permission to create files in the destination bot. If the destination bot ID is omitted, the file will be copied to the same bot the source file belongs to.",
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
        var command = new Command(@"copy-file", @"Copy file");
                        command.Arguments.Add(IdOrKey);
                        command.Arguments.Add(DestinationKey);
                        command.Options.Add(XDestinationBotId);
                        command.Options.Add(XBotId);
                        command.Options.Add(XIntegrationId);
                        command.Options.Add(XIntegrationAlias);
                        command.Options.Add(XIntegrationName);
                        command.Options.Add(XUserId);
                        command.Options.Add(XUserRole);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var idOrKey = parseResult.GetRequiredValue(IdOrKey);
                        var destinationKey = parseResult.GetRequiredValue(DestinationKey);
                        var xDestinationBotId = parseResult.GetValue(XDestinationBotId);
                        var xBotId = parseResult.GetRequiredValue(XBotId);
                        var xIntegrationId = parseResult.GetValue(XIntegrationId);
                        var xIntegrationAlias = parseResult.GetValue(XIntegrationAlias);
                        var xIntegrationName = parseResult.GetValue(XIntegrationName);
                        var xUserId = parseResult.GetValue(XUserId);
                        var xUserRole = parseResult.GetValue(XUserRole);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Files.FilesCopyFileAsync(
                                    idOrKey: idOrKey,
                                    destinationKey: destinationKey,
                                    xDestinationBotId: xDestinationBotId,
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