// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Напишите целое число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number<1) || (number>7)) Console.WriteLine("Введено неверное число");
else
{
bool Weekend (int num)
{
bool week = num==6 || num == 7;
return week;
}
bool result = Weekend (number);
Console.WriteLine(result? "Выходной": "Не является выходным");

}
