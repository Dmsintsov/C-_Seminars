// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


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
PrintArray(array);
Console.WriteLine();

int SumNeg(int[] arr)
{
    int sizeNeg = arr.Length;
    int sumNegative = 0;
    for (int k = 0; k < sizeNeg; k++)
    {
        if (arr[k] < 0) sumNegative += arr[k];
    }
    return sumNegative;
}

int SumPos(int[] arrr)
{
    int sizePos = arrr.Length;
    int sumPositive = 0;
    for (int l = 0; l < sizePos; l++)
    {
        if (arrr[l] > 0) sumPositive += arrr[l];
    }
    return sumPositive;
}

int sumNegNum = SumNeg(array);
int sumPosNum = SumPos(array);
Console.WriteLine($"Сумма отрицательных чисел в массиве равна {sumNegNum}");
Console.WriteLine($"Сумма положительных чисел в массиве равна {sumPosNum}");