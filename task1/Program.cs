// Задайте двумерный массив размером m×n, заполненный
//  случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] FillArrayWithRandomNumbers(int rows, int cows, int leftRange, int rightRange)
{
    Random rand = new Random();
    double[,] array = new double[rows, cows];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double temp = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 1);
            array[i, j] = temp;
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    return array;
}

FillArrayWithRandomNumbers(3, 4, 1, 10);