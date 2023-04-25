// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void FillArray(double[] collection, int min, int max)
{
    int length = collection.Length;
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        collection[i] = random.NextDouble() * (max-min) + min;
    }

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

double MaxMinDifference (double[] arr)
{
int size = arr.Length;
double max = arr[0];
double min = arr[0];
double count = 0;

for (int j = 0; j < size; j++)
{
   if (arr[j]<min)
   {
    min = arr[j];
   }
   if (arr[j]>max)
   {
    max = arr[j];
   }
}

count = max-min;
return count;
    
}



int lengthArray = Text("Введите длину массива: ");
Console.WriteLine();
double[] array = new double[lengthArray];
FillArray(array, 0, 100);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
Console.WriteLine();
double maxMinDifference = Math.Round (MaxMinDifference (array), 1);
Console.WriteLine($"Разница между максимальным и минимальным числами равна: {maxMinDifference}");
