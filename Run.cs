using System.Diagnostics;

namespace ForEachShell
{
    public static class Run
    {
        public static void Execute(Options opts)
        {
            foreach (var directory in Directory.GetDirectories(opts.Input))
            {
                Directory.SetCurrentDirectory(directory);
                using (Process process = new())
                {
                    process.StartInfo.WorkingDirectory = directory;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = $"/c {opts.Command} {opts.Argument.Replace("\\", "")}";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    Console.WriteLine(process.StandardOutput.ReadToEnd());

                    process.WaitForExit();
                }

                Thread.Sleep(opts.TimeInterval * 1000);
            }
        }
    }
}