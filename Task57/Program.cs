// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


void FillMatrix(int[,] matr)
{
    var random = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = random.Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}
int row = Text("Введите количество строк: ");
int column = Text("Введите количество столбцов: ");

int[,] matrix = new int[row, column];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

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

int[] TwoToOneDimensional(int[,] arr)
{
    int[] onedim = new int[row * column];
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            onedim[count] = arr[i, j];
            count++;
        }
    }
    return onedim;
}
int[] twoToOneDimensional = TwoToOneDimensional(matrix);
Array.Sort(twoToOneDimensional);
PrintArray(twoToOneDimensional);
Console.WriteLine();

int[] CountElements(int[] arr)
{
    int maxNumber = 9;
    int[] count = new int[maxNumber];
int sum = 1;
    for (int i = 0; i < maxNumber; i++)
    {
        for (int j = sum-1; j < arr.Length; j++)
        {
           if (arr[j] == i+1) count[i] = count[i] + 1; 
           if (arr[j] == i+1) sum += 1;
        }
        
    }
    return count;
}
int[] countElements = CountElements(twoToOneDimensional);

Console.WriteLine($"Элемент 1 встречается {countElements[0]} раз");
Console.WriteLine($"Элемент 2 встречается {countElements[1]} раз");
Console.WriteLine($"Элемент 3 встречается {countElements[2]} раз");
Console.WriteLine($"Элемент 4 встречается {countElements[3]} раз");
Console.WriteLine($"Элемент 5 встречается {countElements[4]} раз");
Console.WriteLine($"Элемент 6 встречается {countElements[5]} раз");
Console.WriteLine($"Элемент 7 встречается {countElements[6]} раз");
Console.WriteLine($"Элемент 8 встречается {countElements[7]} раз");
Console.WriteLine($"Элемент 9 встречается {countElements[8]} раз");
