// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int numberA = Text ("Введите любое число A: ");
int numberB = Text ("Введите положительное число B: ");

int Pow (int numA, int numB)
{
int res = numA;
for (int i = 1; i < numB; i++)
{
        res *= numA;
}
return res;
}
int result = Pow(numberA, numberB);
if (numberB<0) Console.WriteLine("Второе число должно быть больше нуля");
else{Console.WriteLine(result);}