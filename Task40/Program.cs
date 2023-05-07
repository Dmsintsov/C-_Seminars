// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool Triangle (int numA, int numB, int numC)
{
if (numA < numB + numC && numB < numA + numC && numC < numB + numA) return true;
else return false;
}




int numberA = Text ("Введите положительное число A: ");
int numberB = Text ("Введите положительное число B: ");
int numberC = Text ("Введите положительное число C: ");

bool result = Triangle (numberA, numberB, numberC); 
if (numberA <=0 || numberB <=0 || numberC <=0) Console.WriteLine("Введены неверные числа");
else
{Console.WriteLine(result? "Треугольник может существовать со сторонами такой длины": "Треугольник не может существовать со сторонами такой длины");
}
