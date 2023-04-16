// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int number = Prompt ("Введите число: ");

void Square (int num)
{
int count = 1;
while (count<num+1) 
{
    double square = Math.Pow(count, 2);
Console.WriteLine($"{count, 3} {square, 4}");
count++;
}

}

Square (number);

