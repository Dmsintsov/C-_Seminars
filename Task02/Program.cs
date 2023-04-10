// Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("большее число: "+numberA);
    Console.WriteLine("меньшее число: "+numberB);
}
else
{
  Console.WriteLine("большее число: "+numberB); 
  Console.WriteLine("меньшее число: "+numberA);  
}