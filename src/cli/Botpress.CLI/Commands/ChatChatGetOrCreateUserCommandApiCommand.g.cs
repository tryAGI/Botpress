#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Botpress.CLI.Commands;

internal static partial class ChatChatGetOrCreateUserCommandApiCommand
{
    private static Option<string> XUserKey { get; } = new(
        name: @"--x-user-key")
    {
        Description = @"Authentication Key",
        Required = true,
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Name of the [User](#schema_user) (not a unique identifier)",
    };

    private static Option<string?> PictureUrl { get; } = new(
        name: @"--picture-url")
    {
        Description = @"Picture url of the [User](#schema_user)",
    };

    private static Option<string?> Profile { get; } = new(
        name: @"--profile")
    {
        Description = @"Custom profile data of the [User](#schema_user) encoded as a string",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Botpress.ChatGetOrCreateUserResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Botpress.ChatGetOrCreateUserResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-or-create-user", @"Get Or Create User
Get or create a new [User](#schema_user)");
                        command.Options.Add(XUserKey);
                        command.Options.Add(NameOption);
                        command.Options.Add(PictureUrl);
                        command.Options.Add(Profile);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Botpress.ChatGetOrCreateUserRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Botpress.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xUserKey = parseResult.GetRequiredValue(XUserKey);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var pictureUrl = CliRuntime.WasSpecified(parseResult, PictureUrl) ? parseResult.GetValue(PictureUrl) : (__requestBase is { } __PictureUrlBaseValue ? __PictureUrlBaseValue.PictureUrl : default);
                        var profile = CliRuntime.WasSpecified(parseResult, Profile) ? parseResult.GetValue(Profile) : (__requestBase is { } __ProfileBaseValue ? __ProfileBaseValue.Profile : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Chat.ChatGetOrCreateUserAsync(
                                    xUserKey: xUserKey,
                                    name: name,
                                    pictureUrl: pictureUrl,
                                    profile: profile,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Botpress.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}