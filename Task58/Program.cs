// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] MatrixMultiplication(int[,] matrA, int[,] matrB)
{
    int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < matrC.GetLength(0); i++)
    {
        for (int j = 0; j < matrC.GetLength(1); j++)
        {
            if (matrB.GetLength(0) > matrA.GetLength(1))
            {
                for (int k = 0; k < matrB.GetLength(0); k++)
                {
                    matrC[i, j] += matrA[i, k] * matrB[k, j];

                }
            }
            else
            {
                for (int k = 0; k < matrA.GetLength(1); k++)
                {
                    matrC[i, j] += matrA[i, k] * matrB[k, j];
                }
            }
        }
    }
    return matrC;
}
int rowA = Text("Введите количество строк первой матрицы: ");
int columnA = Text("Введите количество столбцов первой матрицы: ");
int[,] matrixA = new int[rowA, columnA];
FillMatrix(matrixA);
PrintMatrix(matrixA);
Console.WriteLine();
int rowB = Text("Введите количество строк второй матрицы: ");
int columnB = Text("Введите количество столбцов второй матрицы: ");
int[,] matrixB = new int[rowB, columnB];
FillMatrix(matrixB);
PrintMatrix(matrixB);
Console.WriteLine();
if (columnA != rowB) Console.WriteLine("Данные матрицы нельзя перемножить");
else
{
    int[,] matrixMultiplication = MatrixMultiplication(matrixA, matrixB);
    Console.WriteLine("Результирующая матрица: ");
    PrintMatrix(matrixMultiplication);
    Console.WriteLine();
}