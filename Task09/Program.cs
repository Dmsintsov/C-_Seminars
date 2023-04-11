// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 -> {number}");
// int numberA = number / 10;
// int numberB = number % 10;
// if (numberA>numberB) 
// Console.WriteLine($"наибольшая цифра в данном числе {numberA}");
// else
// {
//     Console.WriteLine($"наибольшая цифра в данном числе {numberB}");
//     }

// int maxdigit = numberA > numberB ? numberA : numberB;
// Console.WriteLine($"наибольшая цифра в данном числе {maxdigit}");

int MaxDigit (int num)
{
int numberA = num / 10;
int numberB = num % 10;
int maxdigit = numberA > numberB ? numberA : numberB;
return maxdigit;
}

int maxdigit = MaxDigit (number);
Console.WriteLine($"наибольшая цифра в данном числе {maxdigit}");