// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int number = Text("Введите число: ");

int Length(int num)
{
    int count = 0;
    while (num!= 0 )
    {
num/= 10;
count++;

    }
    
   return count;
}

int result = Length (number);
System.Console.WriteLine(result);