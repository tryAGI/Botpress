#nullable enable

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static class ChatApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"chat", @"Chat endpoint commands.");
                         command.Subcommands.Add(ChatChatAddParticipantCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatCreateConversationCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatCreateEventCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatCreateMessageCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatCreateUserCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatDeleteConversationCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatDeleteMessageCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatDeleteUserCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatGetConversationCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatGetEventCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatGetMessageCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatGetOrCreateConversationCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatGetOrCreateUserCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatGetParticipantCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatGetUserCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatListConversationsCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatListMessagesCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatListParticipantsCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatListenConversationCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatRemoveParticipantCommandApiCommand.Create());
                         command.Subcommands.Add(ChatChatUpdateUserCommandApiCommand.Create());
        return command;
    }
}