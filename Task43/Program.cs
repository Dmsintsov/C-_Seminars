// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


double ParameterX(int k1, int k2, int b1, int b2)
{
    return (b2 - b1) / (double)(k1 - k2);

}

double ParameterY(int k1, int k2, int b1, int b2, double x)
{

    return k1 * x + b1;
}

int numberK1 = Text("Введите коэффициент K1: ");
int numberK2 = Text("Введите коэффициент K2: ");
int numberB1 = Text("Введите коэффициент B1: ");
int numberB2 = Text("Введите коэффициент B2: ");

if (numberK1 == numberK2 && numberB1 == numberB2) Console.WriteLine("Прямые являются одинаковыми");
else
{
    if (numberK1 == numberK2) Console.WriteLine("Прямые являются параллельными");
    else
    {
        double parameterX = Math.Round(ParameterX(numberK1, numberK2, numberB1, numberB2), 1);
        double parameterY = Math.Round(ParameterY(numberK1, numberK2, numberB1, numberB2, parameterX), 1);
        System.Console.WriteLine($"Координаты точки пересечения двух прямых ({parameterX};{parameterY})");
    }
}