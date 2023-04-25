// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void FillArray(int[] collection, int min, int max)
{
    int length = collection.Length;
    var random = new Random();
    for (int i = 0; i < length; i++)
    {
        collection[i] = random.Next(min, max);
    }

}
void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        if (position < col.Length - 1) Console.Write(col[position] + ", ");
        else
        {
            Console.Write(col[position]);
        }
    }

}

int SumEvenIndex (int[] arr)
{
int size = arr.Length;
int count = 0;

for (int j = 0; j < size; j++)
{
   if (j%2!=0)
   {
    count += arr[j];
   }
}
return count;
    
}



int lengthArray = Text("Введите длину массива: ");
Console.WriteLine();
int[] array = new int[lengthArray];
FillArray(array, -100, 100);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
Console.WriteLine();
int sumEvenIndex = SumEvenIndex (array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {sumEvenIndex}");
