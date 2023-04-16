// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int xa = Prompt ("Введите переменную X числа a");
int ya = Prompt ("Введите переменную Y числа a");
int za = Prompt ("Введите переменную Z числа a");
int xb = Prompt ("Введите переменную X числа b");
int yb = Prompt ("Введите переменную Y числа b");
int zb = Prompt ("Введите переменную Z числа b");

double Line (int x1,int y1,int z1,int x2, int y2,int z2)
{
double length = Math.Sqrt(Math.Abs (x1-x2)*Math.Abs (x1-x2)+Math.Abs (y1-y2)*Math.Abs (y1-y2)+Math.Abs (z1-z2)*Math.Abs (z1-z2));
return length;
}

double result = Line (xa, ya, za, xb, yb, zb);
double round = Math.Round (result, 2, MidpointRounding.ToZero);
System.Console.WriteLine(round);
