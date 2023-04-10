// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.WriteLine("Введите целое число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (number<1) Console.WriteLine("Данное число не является натуральным");
if (number==1) Console.WriteLine("Нет четных натуральных чисел меньше заданного числа");
while (count<number-1)
{
    count = count+2;
    Console.Write(count + ", ");
}