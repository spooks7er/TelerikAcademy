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

                    for (int k = 0; k < line.Length; k++)
                    {
                        char kChar = line[k];
                        if ((char.IsUpper(line[k]) && k == 0) || (char.IsUpper(line[k]) && line[k - 1] == '.') || (char.IsUpper(line[k]) && line[k - 1] == '(' && line[k - 2] == ' '))
                        {
                            if (char.IsUpper(line[k]) && k == 0)
                            {
                                firstBracket = line.IndexOf("(", k);
                                int dotIndex = line.IndexOf(".", k);
                                if (dotIndex == -1 )
                                {
                                    for (int l = 0; l < line.Length; l++)
                                    {
                                            firstBracket = line.IndexOf("(", l);
                                            methodNameLen = firstBracket - l;
                                            methodName = line.Substring(l, methodNameLen - 1);
                                            output.Append(methodName + ", ");
                                            counter++;
                                            k += methodNameLen;
                                            break;
                                    }
                                }
                                else
                                {
                                    for (int l = 0; l < line.Length; l++)
                                    {
                                        if (line[l] == '.')
                                        {
                                            firstBracket = line.IndexOf("(", l);
                                            methodNameLen = firstBracket - l;
                                            methodName = line.Substring(l + 1, methodNameLen - 1);
                                            output.Append(methodName + ", ");
                                            counter++;
                                            k += methodNameLen;
                                            break;
                                        }
                                    }
    
                                }

                            }
                            else
                            {
                                firstBracket = line.IndexOf("(", k);
                                if (firstBracket!=-1)
                                {
                                    methodNameLen = firstBracket - k;
                                    methodName = line.Substring(k, methodNameLen);
                                    output.Append(methodName + ", ");
                                    counter++;
                                    k += methodNameLen;
                                }

                            }
                        }
                    }
                    if (line.IndexOf("static") != -1)
                    {
                        i = j - 1;
                        break;
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