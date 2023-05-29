// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
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
int MinRow(int[,] matr)
{
    int minRowIndex = 0;
    int minSum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int count = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            count += matr[i, j];
        }
        if (i == 0) minSum = count;
        else
        {
            if (count < minSum)
            {
                minSum = count;
                minRowIndex = i;
            }
        }
    }
    return minRowIndex;
}
int row = Text("Введите количество строк: ");
int column = Text("Введите количество столбцов: ");
int[,] matrix = new int[row, column];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов: {MinRow(matrix) + 1} строка");