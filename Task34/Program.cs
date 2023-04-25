// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int AmountPositive (int[] arr)
{
int size = arr.Length;
int count = 0;

for (int j = 0; j < size; j++)
{
   if (arr[j]%2==0)
   {
    count +=1;
   }
}
return count;
    
}



int lengthArray = Text("Введите длину массива: ");
Console.WriteLine();
int[] array = new int[lengthArray];
FillArray(array, 100, 1000);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
Console.WriteLine();
int amountPositive = AmountPositive (array);
Console.WriteLine($"Количество четных чисел в массиве: {amountPositive}");
