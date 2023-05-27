// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


int[,] matrix = new int[3, 4];
void FillMatrix(int[,] matr)
{
    var random = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = random.Next(1, 10);
        }
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

void SwitchRows(int[,] matr)
{
    int temp = 0;
for (int i = 0; i < matr.GetLength(1); i++)
    {
        temp = matr[0, i];
        matr[0, i] = matr[matr.GetLength(0)-1, i];
        matr[matr.GetLength(0)-1, i] = temp;
    }
}

    FillMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
    SwitchRows(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();