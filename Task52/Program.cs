// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

double[] ColumnAverage(int[,] image)
{

    double[] average = new double[image.GetLength(1)];

    for (int i = 0; i < image.GetLength(1); i++)
    {
        double sum = 0;
        double count = 0;
        for (int j = 0; j < image.GetLength(0); j++)
        {
            sum += image[j, i];
            count++;

        }
        average[i] = sum / count;
        
    }
        return average;
}

void PrintArray(double[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        double round = Math.Round(col[position], 1);
        if (position < col.Length - 1) Console.Write(round + "; ");
        else
        {
            Console.Write(round);
        }
    }

}

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
double[] columnAverage = ColumnAverage(matrix);
Console.Write("Среднее арифметическое каждого столбца: [");
PrintArray(columnAverage);
Console.WriteLine("]");
Console.WriteLine();