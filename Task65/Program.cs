// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void NaturalNumbersMinToMax(int numA, int numB)
{
    if (numA - 1 == numB) return;
    else
    {

        NaturalNumbersMinToMax(numA, numB - 1);
        Console.Write($"{numB} ");
    }
}

void NaturalNumbersMaxToMin(int numA, int numB)
{
    if (numA +1 == numB) return;
    else
    {

        NaturalNumbersMaxToMin(numA, numB + 1);
        Console.Write($"{numB} ");
    }
}

int numberA = Text("Введите целое положительное число: ");
int numberB = Text("Введите целое положительное число: ");
if (numberA < numberB)
    NaturalNumbersMinToMax(numberA, numberB);
else {NaturalNumbersMaxToMin(numberA, numberB);}