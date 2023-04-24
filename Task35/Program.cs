// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void FillArray(int[] collection)
{
    int length = collection.Length;
    var random = new Random();
    for (int i = 0; i < length; i++)
    {
        collection[i] = random.Next(0, 1000);
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

int AmountNumbers (int[] arr)
{
int size = arr.Length;
int count = 0;

for (int j = 0; j < size; j++)
{
   if (arr[j]>9 && arr[j]<100)
   {
    count +=1;
   }
}
return count;
    
}



int lengthArray = Text("Введите длину массива: ");
int[] array = new int[lengthArray];
FillArray(array);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
Console.WriteLine();
int amountNumbers = AmountNumbers (array);
Console.WriteLine($"Количество двузначных чисел в массиве: {amountNumbers}");