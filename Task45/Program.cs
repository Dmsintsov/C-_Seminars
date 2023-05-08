// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


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

int[] CopyArray(int[] arr)
{
int length = arr.Length;
int[] newarray = new int[length];
for (int i = 0; i < length; i++)
{
    newarray[i] = arr[i];
}
return newarray;
}


int lengthArray = Text("Введите длину массива: ");
int[] array = new int[lengthArray];
FillArray(array);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
Console.WriteLine();
int[] copyArray = CopyArray (array);
Console.Write("[");
PrintArray(copyArray);
Console.WriteLine("]");