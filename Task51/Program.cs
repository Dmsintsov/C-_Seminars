// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int[,] matrix = new int[3, 4];


void FillMatrix(int[,] matr, int min, int max)
{
    
   var random = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = random.Next(min, max);
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
            Console.Write($"{image[i, j], 5} ");

        }
       Console.WriteLine("|");
    }
    
}

int SumDiagonalIndex (int [,] matr)
{
int res = 0;
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i==j)
            res += matr [i,j];
        }

    }
return res;
}

// int SumDiagonalIndex (int [,] matr)
// {
// int res = 0;
// for (int i = 0; i < matr.GetLength(0) && i < matr.GetLength(1); i++)
//     {
//        res += matr [i, i];
    

//     }
// return res;
// }


FillMatrix(matrix, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
SumDiagonalIndex (matrix);
int sumDiagonalIndex = SumDiagonalIndex (matrix);
Console.WriteLine($"сумма значений диагонали равна {sumDiagonalIndex}");