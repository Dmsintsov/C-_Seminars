// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int number = Prompt ("Введите число: ");

void Cube (int num)
{
int count = 1;
while (count<num+1) 
{
    double cube = Math.Pow(count, 3);
Console.WriteLine($"{count, 3} {cube, 5}");
count++;
}

}

Cube (number);
