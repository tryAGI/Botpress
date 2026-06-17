#nullable enable

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static class TablesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"tables", @"Tables endpoint commands.");
                         command.Subcommands.Add(TablesTablesCreateTableCommandApiCommand.Create());
                         command.Subcommands.Add(TablesTablesCreateTableRowsCommandApiCommand.Create());
                         command.Subcommands.Add(TablesTablesDeleteTableCommandApiCommand.Create());
                         command.Subcommands.Add(TablesTablesDeleteTableRowsCommandApiCommand.Create());
                         command.Subcommands.Add(TablesTablesDuplicateTableCommandApiCommand.Create());
                         command.Subcommands.Add(TablesTablesFindTableRowsCommandApiCommand.Create());
                         command.Subcommands.Add(TablesTablesGetOrCreateTableCommandApiCommand.Create());
                         command.Subcommands.Add(TablesTablesGetTableCommandApiCommand.Create());
                         command.Subcommands.Add(TablesTablesGetTableRowCommandApiCommand.Create());
                         command.Subcommands.Add(TablesTablesListTablesCommandApiCommand.Create());
                         command.Subcommands.Add(TablesTablesRenameTableColumnCommandApiCommand.Create());
                         command.Subcommands.Add(TablesTablesUpdateTableCommandApiCommand.Create());
                         command.Subcommands.Add(TablesTablesUpdateTableRowsCommandApiCommand.Create());
                         command.Subcommands.Add(TablesTablesUpsertTableRowsCommandApiCommand.Create());
        return command;
    }
}