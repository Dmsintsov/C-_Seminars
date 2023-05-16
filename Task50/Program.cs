// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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
int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}





FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
int row = Text("Введите номер строки: ");
int column = Text("Введите номер столбца: ");

int PositionValue(int[,] matr, int x, int y)
{
    int res = matr[x, y];
    return res;
}
if (row < 0 || column < 0 || row > 2 || column > 3)
    Console.WriteLine($"Указаны неверные координаты");
else {
    int positionValue = PositionValue(matrix, row, column);
Console.WriteLine($"Значение элемента с указанными позициями равно {positionValue}");
}