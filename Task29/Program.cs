// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int lengthArray = Text ("Введите длину массива: ");

void FillArray(int[] collection)
{
    int length = collection.Length;
    var random = new Random();
    for (int i = 0; i < length; i++)
    {
        collection[i] = random.Next(0, 100);
    }
    
    }

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < 5; position++)
    {
        Console.Write(col[position]+", ");
    }
    System.Console.WriteLine();
       for (int position = 5; position < count; position++)
    {
        Console.Write(col[position]+", ");
    }
    }


int[] array = new int[lengthArray];
FillArray(array);
PrintArray(array);
Console.WriteLine();