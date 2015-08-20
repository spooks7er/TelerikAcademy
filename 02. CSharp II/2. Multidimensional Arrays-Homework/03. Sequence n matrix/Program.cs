using System;
//We are given a matrix of strings of size  N x M . Sequences in the matrix we define 
//as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
class Program
{
    static void Main()
    {
        string[,] stringArr = {
          {"q", "fifi","ho","hi"},
          {"hi", "q",   "hi","xx"},
          {"ha", "a",  "q","xx"}};
        //{"ha", "fifi","ho","hi"},
        //{"hi", "ha",  "hi","xx"},
        //{"xxx","ho",  "ha","xx"}};

        int currLen = 1;
        int bestLen = 1;

        string currStr = string.Empty;
        string bestStr = string.Empty;

        for (int i = 0; i < stringArr.GetLength(0); i++)
        {
            for (int j = 0; j < stringArr.GetLength(1); j++)
            {
                #region
                //search right horizontally
                for (int c = j + 1; c < stringArr.GetLength(1); c++)
                {
                    if (stringArr[i, j] == stringArr[i, c])
                    {
                        currLen++;
                        currStr += stringArr[i, j] + ", ";
                    }
                    else
                    {
                        break;
                    }
                }
                if (currLen > bestLen)
                {
                    bestLen = currLen;
                    bestStr = currStr + stringArr[i, j];
                }
                currLen = 1;

                //search down vertically
                for (int c = i + 1; c < stringArr.GetLength(0); c++)
                {
                    if (stringArr[i, j] == stringArr[c, j])
                    {
                        currLen++;
                        currStr += stringArr[i, j] + ", ";
                    }
                    else
                    {
                        break;
                    }
                }
                if (currLen > bestLen)
                {
                    bestLen = currLen;
                    bestStr = currStr + stringArr[i, j];
                }
                currLen = 1;

                //search down-right diagonally
                for (int c = i + 1; (c < stringArr.GetLength(0)) && (c < stringArr.GetLength(1)); c++)
                {
                    if (stringArr[i, j] == stringArr[c, c])
                    {
                        currLen++;
                        currStr += stringArr[i, j] + ", ";
                    }
                    else
                    {
                        break;
                    }
                }
                if (currLen > bestLen)
                {
                    bestLen = currLen;
                    bestStr = currStr + stringArr[i, j];
                }
                currLen = 1;
                #endregion
                //search down-left diagonally
                for (int c = i + 1; (c < stringArr.GetLength(0)) && (j - c >= 0); c++)
                {
                    if (stringArr[i, j] == stringArr[c, j - c])
                    {
                        currLen++;
                        currStr += stringArr[i, j] + ", ";
                    }
                    else
                    {
                        break;
                    }
                }
                if (currLen > bestLen)
                {
                    bestLen = currLen;
                    bestStr = currStr + stringArr[i, j];
                }
                currLen = 1;
            }
        }

        //Console.WriteLine(bestLen);

        Console.WriteLine(bestStr);
    }
}