// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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
        collection[i] = random.Next(0, 10);
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

void Reverse (int[] arr)
{
    int length = arr.Length;
    int temp = 0;
   
   for (int i = 0; i < length/2; i++)
   {
    temp = arr[i];
    arr[i]=arr[length-1-i];
    arr[length-1-i]=temp;
   }
}


int lengthArray = Text("Введите длину массива: ");
int[] array = new int[lengthArray];
FillArray(array);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
Console.WriteLine();
Reverse (array);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");