// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int xa = Prompt ("Введите переменную X числа a");
int ya = Prompt ("Введите переменную Y числа a");
int xb = Prompt ("Введите переменную X числа b");
int yb = Prompt ("Введите переменную Y числа b");

double Line (int x1,int y1,int x2,int y2)
{
double length = Math.Sqrt(Math.Abs (x1-x2)*Math.Abs (x1-x2)+Math.Abs (y1-y2)*Math.Abs (y1-y2));
return length;
}

double result = Line (xa, ya, xb, yb);
double round = Math.Round (result, 2, MidpointRounding.ToZero);
System.Console.WriteLine(round);