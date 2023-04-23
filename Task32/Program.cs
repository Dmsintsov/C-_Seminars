// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int lengthArray = Text("Введите длину массива: ");

void FillArray(int[] collection)
{
    int length = collection.Length;
    var random = new Random();
    for (int i = 0; i < length; i++)
    {
        collection[i] = random.Next(-9, 10);
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


int[] array = new int[lengthArray];
FillArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("] -> [");

void Reverse(int[] arr)
{
    int length = array.Length;
for (int j = 0; j < length; j++)
{
    arr[j] = -array[j];
}
}

Reverse(array);
PrintArray(array);
Console.Write("]");
Console.WriteLine();