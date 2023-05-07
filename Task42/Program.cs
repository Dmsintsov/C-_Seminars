// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double BinaryNumber (int num)
{
double bin = 0;
for (int i = 0; num >0; i++)
{
    bin = bin + num %2 * Math.Pow (10, i);
    num = num / 2;
}
return bin;

}

int number = Text ("Введите положительное число: ");
double res = BinaryNumber (number);
Console.WriteLine(number<0? "Введено неверное число": $"{res}");

