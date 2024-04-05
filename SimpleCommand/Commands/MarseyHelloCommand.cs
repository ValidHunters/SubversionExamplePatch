using Content.Shared.Administration;
using Robust.Shared.Console;

namespace SimpleCommand.Commands;

[AnyCommand] 
public class CatHelloCommand : IConsoleCommand
{
    private const string Art = """
                                       |\---/|
                                       | ,_, |
                                   \_`_/-..----.
                                   ___/ `   ' ,""+ \  sk
                                       (__...'   __\    |`.___.';
                                   (_,...'(_,.`__)/'.....+
                               """;

    public string Command => "example.subverter.cathello";
    public string Description => "Print Cat-Art in console and chat!";
    public string Help => "HELP!";

    public void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        shell.ExecuteCommand($"say {Art}");
        shell.WriteLine(Art);
    }
}