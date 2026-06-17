#nullable enable

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static class RuntimeApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"runtime", @"Runtime endpoint commands.");
                         command.Subcommands.Add(RuntimeRuntimeAddParticipantCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeCallActionCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeCancelScheduledEventCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeConfigureIntegrationCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeCreateConversationCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeCreateEventCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeCreateMessageCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeCreateUserCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeDeleteConversationCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeDeleteMessageCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeDeleteUserCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeGetConversationCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeGetEventCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeGetMessageCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeGetOrCreateConversationCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeGetOrCreateMessageCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeGetOrCreateUserCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeGetOrSetStateCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeGetParticipantCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeGetStateCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeGetUserCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeListConversationsCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeListEventsCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeListMessagesCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeListParticipantsCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeListTagValuesCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeListUsersCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimePatchStateCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeRemoveParticipantCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeSetStateCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeSetStateExpiryCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeUpdateConversationCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeUpdateMessageCommandApiCommand.Create());
                         command.Subcommands.Add(RuntimeRuntimeUpdateUserCommandApiCommand.Create());
        return command;
    }
}