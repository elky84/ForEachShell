// See https://aka.ms/new-console-template for more information

using CommandLine;
using ForEachShell;

{
    try
    {
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(String.Format("{0}: ({1})", i, args[i]));
        }

        Parser.Default.ParseArguments<Options>(args)
            .WithParsed<Options>(opts => Run.Execute(opts))
            .WithNotParsed<Options>((errs) => Options.HandleParseError(errs));
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Unhandled exception. <Reason:{exception.Message}> <StackTrace:{exception.StackTrace}>");
        Environment.Exit(ErrorCode.EXCEPTION);
    }
}