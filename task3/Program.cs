Random random = new Random();
int rows = 3;
int columns = 4;
int[,] array = new int[rows, columns];
double sum = 0;

for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 11);
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

for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        Console.Write(Math.Round(sum/rows, 1) + "\t");
    }