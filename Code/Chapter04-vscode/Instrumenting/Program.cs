
using System.Diagnostics;
// See https://aka.ms/new-console-template for more information

Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt"))));
Trace.AutoFlush = true;

Debug.WriteLine("Debug says!");
Trace.WriteLine("Trace says!");
