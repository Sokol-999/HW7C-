// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
//                                                          в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

void ArithmeticMeanOfTheCous(int[,] array, int rows)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double res = 0;
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            res = (res + array[i, j]);
        }
        result = res / rows;
        System.Console.Write(Math.Round(result, 3) + "\t");
    }
}

int[,] array = FillArrayWithRandomNumbers(3, 4, 1, 10);
System.Console.WriteLine();
ArithmeticMeanOfTheCous(array, 3);
