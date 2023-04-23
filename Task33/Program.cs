// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int TextNumber(string mess)
{
    Console.WriteLine(mess);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int lengthArray = Text("Введите длину массива: ");
int textNumber = TextNumber("Введите число: ");


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

bool PresenseNumber (int[] arr)

{
int length = arr.Length;
for (int j = 0; j < length; j++)
{
    if (arr[j] == textNumber) return true;
    }
return false;
}

int[] array = new int[lengthArray];
FillArray(array);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

bool presenceNumber = PresenseNumber (array);
// if (presenceNumber == true) Console.WriteLine("да");
// else{ Console.WriteLine("нет");
// }

Console.WriteLine(presenceNumber? "Да": "нет");
