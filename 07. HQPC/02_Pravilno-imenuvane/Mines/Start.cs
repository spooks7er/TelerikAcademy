namespace Mines
{
    using System;
    using System.Collections.Generic;

    class Start
    {
        static void Main(string[] args)
        {
            const int Max = 35;
            string command = string.Empty;
            char[,] field = Game.CreateField();
            char[,] bombs = Game.PutBombs();
            int counter = 0;
            bool boom = false;
            List<PointsGetter> chanpions = new List<PointsGetter>(6);
            int row = 0;
            int col = 0;
            bool flag = true;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    Game.DwarMinesField(field);
                    flag = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Game.HighScores(chanpions);
                        break;
                    case "restart":
                        field = Game.CreateField();
                        bombs = Game.PutBombs();
                        Game.DwarMinesField(field);
                        boom = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                Game.YourTurn(field, bombs, row, col);
                                counter++;
                            }

                            if (Max == counter)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                Game.DwarMinesField(field);
                            }
                        }
                        else
                        {
                            boom = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (boom)
                {
                    Game.DwarMinesField(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", counter);
                    string niknejm = Console.ReadLine();
                    PointsGetter t = new PointsGetter(niknejm, counter);

                    if (chanpions.Count < 5)
                    {
                        chanpions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < chanpions.Count; i++)
                        {
                            if (chanpions[i].Points < t.Points)
                            {
                                chanpions.Insert(i, t);
                                chanpions.RemoveAt(chanpions.Count - 1);
                                break;
                            }
                        }
                    }

                    chanpions.Sort((PointsGetter r1, PointsGetter r2) => r2.Name.CompareTo(r1.Name));
                    chanpions.Sort((PointsGetter r1, PointsGetter r2) => r2.Points.CompareTo(r1.Points));
                    Game.HighScores(chanpions);

                    field = Game.CreateField();
                    bombs = Game.PutBombs();
                    counter = 0;
                    boom = false;
                    flag = true;
                }

                if (flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    Game.DwarMinesField(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    PointsGetter to4kii = new PointsGetter(imeee, counter);
                    chanpions.Add(to4kii);
                    Game.HighScores(chanpions);
                    field = Game.CreateField();
                    bombs = Game.PutBombs();
                    counter = 0;
                    flag2 = false;
                    flag = true;
                }
            }
            while (command != "exit");
            {
                Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
                Console.WriteLine("AREEEEEEeeeeeee.");
                Console.Read();
            }
        }
    }
}
