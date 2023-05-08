// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void FillFibbonacciArray(int[] collection)
{
    int length = collection.Length;
    collection[0] = 0;
    collection[1] = 1;
    for (int i = 2; i < length; i++)
    {

        collection[i] = collection[i - 1] + collection[i - 2];

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

int lengthArray = Text("Введите длину массива: ");
int[] array = new int[lengthArray];
FillFibbonacciArray(array);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
Console.WriteLine();
