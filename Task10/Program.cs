// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int MiddleNumber (int num)
{
int numA = num/100;
int numB = num%10;
int res = (num-(numA*100)-numB)/10;
return res;
}

if ((number < 100) || (number > 999))
{
    Console.WriteLine("Число не является трёхзначным!");
}
else
{
int result = MiddleNumber(number);
Console.WriteLine(result);
}


