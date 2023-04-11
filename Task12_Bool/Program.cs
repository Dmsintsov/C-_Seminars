// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int remainder = numberA % numberB;
bool Multiplicity(int numA, int numB)
{

    bool res = numA/numB == 0;
    return res;
}

bool result = Multiplicity(numberA, numberB);
Console.WriteLine (result ? "число является кратным":$"число не является кратным, остаток равен {remainder}");

