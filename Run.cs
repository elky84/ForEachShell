using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ForEachShell
{
    public static class Run
    {
        public static void Execute(Options opts)
        {
            foreach (var directory in Directory.GetDirectories(opts.Input))
            {
                using (Process process = new())
                {
                    process.StartInfo.WorkingDirectory = $"{opts.Input}/{directory}";

                    if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        process.StartInfo.FileName = "cmd.exe";
                        process.StartInfo.Arguments = $"/c {opts.Command} {opts.Argument.Replace("\\", "")}";
                    }
                    else
                    {
                        process.StartInfo.FileName = opts.Command;
                        process.StartInfo.Arguments = opts.Argument.Replace("\\", "");
                    }

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