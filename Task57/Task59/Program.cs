// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

int[] MinElement(int[,] matr)
{
    int[] elements = new int[2];
    int i = 0;
    int j = 0;
    int min = matr[0, 0];

    for (i = 0; i < matr.GetLength(0); i++)
    {
        for (j = i; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                elements[0] = i;
                elements[1] = j;

                Console.WriteLine(elements[0]);
                Console.WriteLine(elements[1]);
            }
        }
    }
    return elements;
}
int row = Text("Введите количество строк: ");
int column = Text("Введите количество столбцов: ");

int[,] matrix = new int[row, column];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

int[] minElement = MinElement(matrix);

int[,] NewMatrix(int[,] matr, int row, int column)
{
    int[,] newMatr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    for (int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            if (i < row && j < column) newMatr[i, j] = matr[i, j];
            else
            {
                if (i >= row && j >= column) newMatr[i, j] = matr[i + 1, j + 1];
                else
                {
                    if (i >= row) newMatr[i, j] = matr[i + 1, j];
                    else
                    {
                        if (j >= column) newMatr[i, j] = matr[i, j + 1];
                    }
                }
            }
        }
    }
    return newMatr;
}

int[,] newMatrix = NewMatrix(matrix, minElement[0], minElement[1]);
PrintMatrix(newMatrix);