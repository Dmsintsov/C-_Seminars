// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = -numberA;
if (numberA > numberB)
{
    while (numberA>numberB-1)
    {
       Console.Write(numberB);
       Console.Write(", ");
       numberB = numberB+1;
    }
}
if (numberB > numberA)
{
    while (numberB>numberA-1)
    {
       Console.Write(numberA+", ");
       numberA++;
    }
}