// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int number = Prompt ("Введите пятизначное число: ");

string Reverse (int num)
{
    if (num < 10000 || num > 99999) return "Введено неверное число";
    int numA = num/10000;
    int numE = num%10;
    int numB = num/1000%10;
    int numD = num/10%10;
    if (numA == numE && numB == numD) return "Да";
    return "нет";
}

string result = Reverse (number);
Console.WriteLine(result);
