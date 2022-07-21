Random random = new Random();
int rows = 3;
int columns = 4;
double[,] array = new double[rows, columns];

for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round((random.NextDouble() * 20 - 10), 1);
        }
    }

for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }