// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

string path = Environment.ExpandEnvironmentVariables("%PythonHome%");
Console.WriteLine(path);
string arguments = @"sample_script.py";
var cmd = $"{path}\\python.exe";

ProcessStartInfo start = new ProcessStartInfo();
start.FileName = cmd;//cmd is full path to python.exe
start.Arguments = arguments;//args is path to .py file and any cmd line args
start.UseShellExecute = false;
start.RedirectStandardOutput = true;
using(Process process = Process.Start(start))
{
    using(StreamReader reader = process.StandardOutput)
    {
        string result = reader.ReadToEnd();
        Console.Write(result);
    }
}