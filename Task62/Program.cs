// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = new int[4, 4];

void FillMatrix(int[,] matr)
{
    int count = 0;
    int i = 0;
    int j = 0;

    for (j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = count;
        count++;
    }


    j = 3;

    for (i = 1; i < matr.GetLength(0); i++)
    {
        matr[i, j] = count;
        count++;
    }
    i = 3;
    for (j = 2; j != -1; j--)
    {
        matr[i, j] = count;
        count++;
    }
    j = 0;

    for (i = 2; i > 0; i--)
    {
        matr[i, j] = count;
        count++;
    }
    i = 1;

    for (j = 1; j < matr.GetLength(1) - 1; j++)
    {
        matr[i, j] = count;
        count++;
    }
    i = 2;

    for (j = 2; j > 0; j--)
    {
        matr[i, j] = count;
        count++;
    }
}
void PrintMatrix(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

FillMatrix(matrix);
PrintMatrix(matrix);

