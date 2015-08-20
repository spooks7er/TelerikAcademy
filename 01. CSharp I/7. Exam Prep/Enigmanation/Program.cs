using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigmanation
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "(1+9)%6-(7%2)*8=";
            string input = Console.ReadLine();
            
            decimal result = 0;
            decimal bracketResult = 0;

            char currentOperator = '+';
            char currentBracketOperator = '+';

            bool inBracket = false;

            foreach (char symbol in input)
            {
                if (symbol == '(')
                {
                    inBracket = true;
                    continue;
                }
                if (symbol == ')')
                {
                    inBracket = false;
                    switch (currentOperator)
                    {
                        case '+': result += bracketResult; break;
                        case '-': result -= bracketResult; break;
                        case '*': result *= bracketResult; break;
                        case '%': result %= bracketResult; break;
                    }
                    bracketResult = 0;
                    currentBracketOperator = '+';
                }

                if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '%')
                {
                    if (inBracket)
                    {
                        currentBracketOperator = symbol;
                    }
                    else
                    {
                        currentOperator = symbol;
                    }
                }

                if (char.IsDigit(symbol))
                {
                    if (inBracket)
                    {
                        switch (currentBracketOperator)
                        {
                            case '+': bracketResult += symbol - '0'; break;
                            case '-': bracketResult -= symbol - '0'; break;
                            case '*': bracketResult *= symbol - '0'; break;
                            case '%': bracketResult %= symbol - '0'; break;
                        }
                    }
                    else
                    {
                        switch (currentOperator)
                        {
                            case '+': result += symbol - '0'; break;
                            case '-': result -= symbol - '0'; break;
                            case '*': result *= symbol - '0'; break;
                            case '%': result %= symbol - '0'; break;
                        }
                    }
                }
            }
            Console.WriteLine("{0:F3}",result);
        }
    }
}