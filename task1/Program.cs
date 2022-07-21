Random random = new Random();
int rows = 3;
int columns = 4;
double[,] array = new double[rows, columns];

for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.NextDouble() * 20 - 10;
        }
    }

for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(Math.Round(array[i, j], 1) + "\t");
        }
        Console.WriteLine();
    }