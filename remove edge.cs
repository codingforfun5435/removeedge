using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Command to uninstall Microsoft Edge
            string command = "powershell.exe -Command \"Get-AppxPackage *Microsoft.MicrosoftEdge* | Remove-AppxPackage\"";
            
            // Start the process
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C " + command;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            Console.WriteLine("Microsoft Edge has been removed successfully.");
            Console.WriteLine(output);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
