﻿using static System.Console;


string path = @"../Operators/";
Write("Press R for read-only or W for writeable: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
Stream? s;
if (key.Key == ConsoleKey.R)
{
    s = File.Open(
    Path.Combine(path, "Program.cs"),
    FileMode.OpenOrCreate,
    FileAccess.Read);
}
else
{
    s = File.Open(
    Path.Combine(path, "Program.cs"),
    FileMode.OpenOrCreate,
    FileAccess.Write);
}
string message;
message = s switch
{
    FileStream writeableFile when s.CanWrite
     => "The stream is a file that I can write to.",
    FileStream readOnlyFile
    => "The stream is a read-only file.",
    MemoryStream ms
    => "The stream is a memory address.",
    null
    => "The stream is null.",
    _
    => "The stream is some other type."
};
WriteLine(message);

