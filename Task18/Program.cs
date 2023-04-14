// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int number = Prompt ("Введите число от 1 до 4: ");

string Quarter (int num)
{
    if (num == 1) return "x>0, y >0";
    if (num == 2) return "x<0, y >0";
    if (num == 3) return "x<0, y <0";
    if (num == 4) return "x>0, y <0";
    return "Введено неверное число";

}
string result = Quarter (number);
System.Console.WriteLine($"Диапазон возможных координат точек: {result}");