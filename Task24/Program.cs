// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int number = Text ("Введите число: ");
int Sum (int num)
{
int res = 0;
for (int i = 0; i < num; i++)
{
    res += i+1;


}
return res;

}
int result = Sum (number);
System.Console.WriteLine(result);