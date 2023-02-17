// Напишите программу, которая на вход принимает число, возвращает индексы этого элемента
//  в двумерном массиве или же указание, что такого числа нет.
// Например, задан массив
// 1 4 7 2

// 5 9 2 3

// 8 4 2 4



int[,] FillArrayWithRandomNumbers(int rows, int cows, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[,] array = new int[rows, cows];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(leftRange, rightRange);
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    return array;
}

int InputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();

        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("ERROR, try again");
    }
    return number;
}

int[,] array = FillArrayWithRandomNumbers(3, 4, 1, 10);
System.Console.WriteLine();

int N = InputNumber("Write a number: ");

bool f = false;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == N)
        {
            f = true;
            Console.Write($"Coords: {(i, j)}, ");
        }
    }
}
Console.WriteLine();
if (f)
    System.Console.WriteLine();
else
    Console.WriteLine("The number is missing");



