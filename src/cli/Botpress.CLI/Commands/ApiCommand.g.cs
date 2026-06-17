#nullable enable

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AdminApiGroupCommand.Create());
                         command.Subcommands.Add(ChatApiGroupCommand.Create());
                         command.Subcommands.Add(FilesApiGroupCommand.Create());
                         command.Subcommands.Add(RuntimeApiGroupCommand.Create());
                         command.Subcommands.Add(TablesApiGroupCommand.Create());
        return command;
    }
}