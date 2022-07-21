Random random = new Random();
int rows = 3;
int columns = 4;
int[,] array = new int[rows, columns];

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

Console.WriteLine("Введите номер строки");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int userColumn = Convert.ToInt32(Console.ReadLine());
if (userRow >= 1 && userRow <= rows && userColumn >= 1 && userColumn <= columns)
{
    Console.WriteLine("Ваше число: " + array[userRow-1, userColumn-1]);
}
else
{
    Console.WriteLine("Числа не существует");
}