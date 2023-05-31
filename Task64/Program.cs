// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int number = Text("Введите целое положительное число: ");
if (number < 1) Console.WriteLine("Введено неверное число");
else
{
    NumbersToOne(number);
    void NumbersToOne(int num)
    {
        if (num == 0) return;
        Console.Write($"{num}");
        NumbersToOne(num - 1);
    }
}
