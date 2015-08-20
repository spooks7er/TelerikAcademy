using System;
//Write a program that generates and prints all possible cards from a standard deck of 52 
//cards (without the jokers). The cards should be printed using the classical notation 
//(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds). ◦ The card faces should start from 2 to A.
//◦ Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
//Use 2 nested for-loops and a switch-case statement.
class Program
{
    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                if (i <= 9)
                {
                    switch (j)
                    {
                        case 1: Console.Write(" {0} of ♠, ", i); break;
                        case 2: Console.Write(" {0} of ♣, ", i); break;
                        case 3: Console.Write(" {0} of ♥, ", i); break;
                        case 4: Console.Write(" {0} of ♦, ", i); break;
                        default:
                            break;
                    }
                }
                else if (i == 10)
                {
                    switch (j)
                    {
                        case 1: Console.Write("{0} of ♠, ", i); break;
                        case 2: Console.Write("{0} of ♣, ", i); break;
                        case 3: Console.Write("{0} of ♥, ", i); break;
                        case 4: Console.Write("{0} of ♦, ", i); break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (j)
                    {
                        case 1: Console.Write(" J of ♠, ", i); break;
                        case 2: Console.Write(" Q of ♣, ", i); break;
                        case 3: Console.Write(" K of ♥, ", i); break;
                        case 4: Console.Write(" A of ♦, ", i); break;
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}