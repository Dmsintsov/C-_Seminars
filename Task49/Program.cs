// адача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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

void SquarePositiveIndex (int [,] matr)
{

for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i%2 == 0 && j%2 == 0)
            matr[i, j] *= matr[i, j];
        }

    }

}


FillMatrix(matrix, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
SquarePositiveIndex (matrix);
PrintMatrix(matrix);