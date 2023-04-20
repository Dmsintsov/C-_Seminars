// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int number = Text ("Введите число: ");
int Sum (int num)
{
int res = 1;
for (int i = 1; i < num; i++)
{
    checked
    {
        res *= i+1;
    }

}
return res;

}
int result = Sum (number);
System.Console.WriteLine(result);
