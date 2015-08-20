38 
static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                var currentNumbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < currentNumbers.Length; j++)
                {
                    numbers[i, j] = int.Parse(currentNumbers[j]);
                }
            }

            List<bool[,]> patterns = new List<bool[,]>();
            InitPatterns(patterns);

            int sum = 0;
            for (int row = 0; row < numbers.GetLength(0) - 4; row++)
            {
                for (int col = 0; col < numbers.GetLength(1) - 2; col++)
                {
                    for (int pattern = 0; pattern < patterns.Count; pattern++)
                    {
                        var currentPattern = patterns[pattern];
                        if (CheckCurrentPattern(numbers, currentPattern, row, col, pattern))
                        {
                            sum += pattern;
                        }
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}