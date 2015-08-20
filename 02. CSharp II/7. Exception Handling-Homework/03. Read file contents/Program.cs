using System;
using System.IO;
//Problem 3. Read file contents
//• Write a program that enters file name along with its full file path 
//(e.g.  C:\WINDOWS\win.ini ), reads its contents and prints it on the console.
//• Find in MSDN how to use  System.IO.File.ReadAllText(…) .
//• Be sure to catch all possible exs and print user-friendly error messages.
class Program
{
    static void Main(string[] args)
    {
        string path = "C:\\WINDOWS\\win.ini";
        try
        {
            using (StreamReader stream = new StreamReader(path))
            {
                Console.WriteLine(stream.ReadToEnd());
            }
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (EndOfStreamException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DriveNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}