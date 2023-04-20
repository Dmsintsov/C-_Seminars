// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int number = Text ("Введите число: ");

int SumNumbers (int num)
{
    int sum = 0;
while (num>0) 
{
sum += num%10;
num /= 10;
}
return sum;
}
int result = SumNumbers (Math.Abs(number));
Console.WriteLine(result);





