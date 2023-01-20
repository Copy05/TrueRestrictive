using System;
using System.Diagnostics;

namespace TrueRestrictive
{
    internal class Helpers
    {
        /// <summary>
        /// Executes a command.
        /// </summary>
        public static void ExecuteCommand(string command)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = "/C" + command;
            process.StartInfo = startInfo;
            process.Start();
        }

        public static void KillProcess(string proc)
        {
            ExecuteCommand("taskkill /f /im " + proc);
        }

        /// <summary>
        /// Ends the application and starts explorer.exe
        /// </summary>
        /// <param name="exitcode"> By default 0</param>
        public static void Exit(int exitcode = 0)
        {
            ExecuteCommand("start explorer.exe");
            Environment.Exit(exitcode);
        }

    }
}
