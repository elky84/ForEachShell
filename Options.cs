using CommandLine;

namespace ForEachShell
{

    public partial class Options
    {
        [Option('i', "input", Required = true, HelpText = "Input directory.")]
        public string Input { get; set; } = "";

        [Option('c', "command", Required = true, HelpText = "Input command.")]
        public string Command { get; set; } = "";

        [Option('a', "argument", Required = true, HelpText = "Input argument.")]
        public string Argument { get; set; } = "";

        [Option('t', "time", Required = false, HelpText = "time interval (unit seconds)")]
        public int TimeInterval { get; set; } = 0;

        public static void HandleParseError(IEnumerable<Error> errs)
        {
            foreach (var err in errs)
            {
                Console.WriteLine(err.ToString());
            }
        }
    }
}
