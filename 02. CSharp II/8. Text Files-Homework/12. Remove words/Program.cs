using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 12. Remove words
//• Write a program that removes from a text file all words listed in given another text file.
//• Handle all possible exceptions in your methods.

class Program
{
    static void Main(string[] args)
    {
        string firstFile = @"..\..\SomeText1.txt";
        string secondFile = @"..\..\SomeText2.txt";
        //List<string> result = new List<string>();
        List<string> forbidden = new List<string>();

        StringBuilder result = new StringBuilder();
        try
        {
            using (StreamReader reader = new StreamReader(secondFile))
            {
                while (!reader.EndOfStream)
                {
                    string[] words = reader.ReadLine()
                        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    forbidden.AddRange(words);
                }
            }
            using (StreamReader reader = new StreamReader(firstFile))
            {
                while (!reader.EndOfStream)
                {
                    result.AppendLine(reader.ReadLine());
                }
            }
            string text = result.ToString();
            foreach (var word in forbidden)
            {
                text = text.Replace(word, "");
            }

            using (StreamWriter writer = new StreamWriter(firstFile))
            {
                writer.WriteLine(text);
            }
            Console.WriteLine("Done!");
        }
        catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileLoadException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (EndOfStreamException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (IOException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentNullException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}