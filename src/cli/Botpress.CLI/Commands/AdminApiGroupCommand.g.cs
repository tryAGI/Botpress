#nullable enable

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static class AdminApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"admin", @"Admin endpoint commands.");
                         command.Subcommands.Add(AdminAdminCreateBotCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminCreateIntegrationCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminCreateWorkspaceCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminCreateWorkspaceMemberCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminDeleteBotCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminDeleteBotIssueCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminDeleteIntegrationCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminDeleteWorkspaceCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminDeleteWorkspaceMemberCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetAccountCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetAuditRecordsCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetBotCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetBotAnalyticsCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetBotIssueCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetBotLogsCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetIntegrationCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetIntegrationByNameCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetIntegrationLogsCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetPublicIntegrationCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetPublicIntegrationByIdCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetPublicWorkspaceCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetWorkspaceCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminGetWorkspaceMemberCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminListBotIssueEventsCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminListBotIssuesCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminListBotsCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminListIntegrationsCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminListPublicIntegrationsCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminListPublicWorkspacesCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminListWorkspaceMembersCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminListWorkspacesCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminUpdateAccountCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminUpdateBotCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminUpdateIntegrationCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminUpdateWorkspaceCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminUpdateWorkspaceMemberCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminValidateIntegrationCreationCommandApiCommand.Create());
                         command.Subcommands.Add(AdminAdminValidateIntegrationUpdateCommandApiCommand.Create());
        return command;
    }
}