// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillArray(int[] collection)
{
    int length = collection.Length;

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите число {i + 1}");
        collection[i] = Convert.ToInt32(Console.ReadLine());
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

int CountPositive (int[] arr)
{
int length = arr.Length;
int count = 0;
for (int i = 0; i < length; i++)
{
    if (arr[i]>0) count+= 1;
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
int countPositive = CountPositive (array);
System.Console.WriteLine($"Количество положительных чисел равно {countPositive}");