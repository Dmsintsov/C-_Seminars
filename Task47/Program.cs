// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] matrix = new double[3, 4];


void FillMatrix(double[,] matr, int min, int max)
{
    Random random = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = random.NextDouble() * (max - min) + min;
        }

    }
}
void PrintMatrix(double[,] image)
{


    for (int i = 0; i < image.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(image[i, j], 1),5} ");

        }
        Console.WriteLine("|");
    }

}

FillMatrix(matrix, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();