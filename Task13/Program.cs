﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number<100) && (number>-100)) Console.WriteLine("третьей цифры нет");
else
{
int ThirdDigit (int num)
{
while ((num>999) || (num<-999))
{
    num = num/10;
}
int res = num % 10<0? -num % 10: num % 10;
return res;
}

int result = ThirdDigit (number);

Console.WriteLine(result);
}