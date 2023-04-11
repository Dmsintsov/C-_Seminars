// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
bool Remainder (int num)
{
bool rem = num%7==0 && num%23==0;
return rem;
}

bool result = Remainder(numberA);
Console.WriteLine (result? "число одновременно кратно 7 и 23": "число не кратно одновременно 7 и 23");

