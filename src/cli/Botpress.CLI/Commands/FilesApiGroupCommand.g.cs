#nullable enable

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static class FilesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"files", @"Files endpoint commands.");
                         command.Subcommands.Add(FilesFilesCopyFileCommandApiCommand.Create());
                         command.Subcommands.Add(FilesFilesDeleteFileCommandApiCommand.Create());
                         command.Subcommands.Add(FilesFilesGetFileCommandApiCommand.Create());
                         command.Subcommands.Add(FilesFilesListFilePassagesCommandApiCommand.Create());
                         command.Subcommands.Add(FilesFilesListFileTagValuesCommandApiCommand.Create());
                         command.Subcommands.Add(FilesFilesListFileTagsCommandApiCommand.Create());
                         command.Subcommands.Add(FilesFilesListFilesCommandApiCommand.Create());
                         command.Subcommands.Add(FilesFilesSearchFilesCommandApiCommand.Create());
                         command.Subcommands.Add(FilesFilesUpdateFileMetadataCommandApiCommand.Create());
                         command.Subcommands.Add(FilesFilesUpsertFileCommandApiCommand.Create());
        return command;
    }
}