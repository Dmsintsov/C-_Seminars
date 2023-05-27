// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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

void SwitchRows(int[,] matr)
{
    int temp = 0;
for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = i; j < matr.GetLength(1); j++)
       {
               
        temp = matr[i, j];
        matr[i, j] = matr[j, i];
        matr[j, i] = temp;
    }
    }
}
int row = Text("Введите количество строк: ");
int column = Text("Введите количество столбцов: ");
if (row != column) Console.WriteLine("Невозможно поменять местами ряды и столбцы в массиве с данными параметрами");
else{
int[,] matrix = new int[row, column];
    FillMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
    SwitchRows(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
}
