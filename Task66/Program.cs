// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int NumbersToOne(int numA, int numB)
{
    if (numA == numB + 1) return 0;
    else return numA + NumbersToOne(numA + 1, numB);
}
int numberA = Text("Введите целое положительное число: ");
int numberB = Text("Введите целое положительное число: ");

if (numberA < 1 || numberB < 1) Console.WriteLine("Введено неверное число");
else
if (numberA > numberB) Console.WriteLine(NumbersToOne(numberB, numberA));
else
{
    Console.WriteLine(NumbersToOne(numberA, numberB));
}
