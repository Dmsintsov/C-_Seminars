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

string Multiplicity(int numA, int numB)
{
    string remainder = Convert.ToString(numA % numB);
    string res = remainder == "0" ? res = "число является кратным" : res = $"число не является кратным, остаток равен {remainder}";
    return res;
}
string result = Multiplicity(numberA, numberB);
Console.WriteLine(result);
