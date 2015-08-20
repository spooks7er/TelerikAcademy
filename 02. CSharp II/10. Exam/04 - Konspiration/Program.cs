using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int linesNumber = int.Parse(Console.ReadLine());

        var lines = new string[linesNumber];

        for (int i = 0; i < linesNumber; i++)
        {
            var currentLine = Console.ReadLine();
            lines[i] = currentLine;
        }
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < lines.Length; i++)
        {

            string line = lines[i].Trim();
            int staticIndex = line.IndexOf("static");
            if (staticIndex != -1)
            {
                //string afterStatic = line.Substring(6);
                int afterType = line.IndexOf(" ", 7);
                int firstBracket = line.IndexOf("(");
                int methodNameLen = (firstBracket - afterType);
                string methodName = line.Substring(afterType + 1, methodNameLen - 1);
                output.Append(methodName + " -> ");
                int methodLastindexinSB = output.Length + 1;
                int counter = 0;
                for (int j = i + 1; j < lines.Length; j++)
                {
                    line = lines[j].Trim();
                    int dotIndex = line.IndexOfAny(new char[] { '.', '(' });
                    if (line.IndexOf("static") != -1)
                    {
                        i = j - 1;
                        break;
                    }

                    if (dotIndex != -1)
                    {
                        for (int k = dotIndex; k < line.Length; k++)
                        {
                            if (dotIndex != -1 && line[k - 1] != ' ' && char.IsUpper(line[k+1]))
                            {
                                firstBracket = line.IndexOf('(', k + 1);
                                if (firstBracket < 0)
                                {
                                    break;
                                }
                                methodNameLen = (firstBracket - k);
                                methodName = line.Substring(k + 1, methodNameLen - 1);
                                //methodName = methodName.Substring(methodName.IndexOf('.'));
                                output.Append(methodName + ", ");
                                counter++;
                            }
                            int nextDotIndex = line.IndexOfAny(new char[] { '.' ,'('}, k + 1);

                            if (nextDotIndex == -1)
                            {
                                break;
                            }
                            k = nextDotIndex - 1;
                        }
                    }
                }

                output.Insert(methodLastindexinSB - 5, " -> " + counter.ToString());
                if (counter == 0)
                {
                    output.Remove(output.Length - 3, 1);
                }
                counter = 0;
                output.Remove(output.Length - 2, 1);
                output.Append("\n");
            }
        }
        Console.WriteLine(output);
    }
}