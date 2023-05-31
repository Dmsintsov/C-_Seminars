// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int Ackerman(int numA, int numB)
{
    if (numA == 0) return numB + 1;

    if (numB == 0) return Ackerman(numA - 1, 1);
    return Ackerman(numA - 1, Ackerman(numA, numB - 1));

}
int numberA = Text("Введите целое положительное число: ");
int numberB = Text("Введите целое положительное число: ");
if (numberA < 0 || numberB < 0) Console.WriteLine("Введено неверное число");
else Console.WriteLine(Ackerman(numberA, numberB));