// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 31
// [6 7 3 6] -> 36 21

// int Text(string message)
// {
//     Console.WriteLine(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }
// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     var random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         collection[i] = random.Next(0, 1000);
//     }

// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     for (int position = 0; position < count; position++)
//     {
//         if (position < col.Length - 1) Console.Write(col[position] + ", ");
//         else
//         {
//             Console.Write(col[position]);
//         }
//     }

// }

// void SumPairs(int[] arr, int[] arr2)
// {
//     int length = arr.Length;
//     int k = 0;

//     if (length % 2 == 0)
//     {
//         for (int j = 0; j < length / 2; j++)
//         {
//             arr2[k] = arr[j] + arr[length - 1 - k];
//             k += 1;
//         }
//     }
//     else
//     {

//         for (int j = 0; j < length / 2; j++)
//         {
//             arr2[k] = arr[j] + arr[length - 1 - k];
//             k += 1;

//         }

//         arr2[k] = arr[length / 2];
//     }

// }




// int lengthArray = Text("Введите длину массива: ");
// int[] array = new int[lengthArray];
// FillArray(array);
// Console.Write("[");
// PrintArray(array);
// Console.WriteLine("]");
// Console.WriteLine();

// int newLength = lengthArray / 2;
// if (lengthArray % 2 != 0)    newLength = lengthArray / 2 + 1;


// int[] newArr1 = new int[newLength];
// SumPairs(array, newArr1);
// Console.Write("[");
// PrintArray(newArr1);
// Console.WriteLine("]");
// Console.WriteLine();


// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 31
// [6 7 3 6] -> 36 21

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

int[] ProductPairs(int[] arr)
{
    int length = arr.Length;
    int k = 0;
    int newLength = arr.Length / 2;
    if (arr.Length % 2 != 0) newLength = arr.Length / 2 + 1;
    int[] newArr1 = new int[newLength];

    if (length % 2 == 0)
    {
        for (int j = 0; j < length / 2; j++)
        {
            newArr1[k] = arr[j] * arr[length - 1 - k];
            k += 1;
        }
    }
    else
    {

        for (int j = 0; j < length / 2; j++)
        {
            newArr1[k] = arr[j] * arr[length - 1 - k];
            k += 1;

        }

        newArr1[k] = arr[length / 2];
    }
return newArr1;
}




int lengthArray = Text("Введите длину массива: ");
int[] array = new int[lengthArray];
FillArray(array);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
Console.WriteLine();


int[] result = ProductPairs(array);
Console.Write("[");
PrintArray(result);
Console.WriteLine("]");
Console.WriteLine();