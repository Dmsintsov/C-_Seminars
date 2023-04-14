// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int paramX = Prompt("Введите параметр X: ");
int paramY = Prompt("Введите параметр Y: ");

string Quarter(int numberx, int numbery)
{
    if (paramX > 0 && paramY > 0) return "Точка находится в четверти 1";
    if (paramX < 0 && paramY > 0) return "Точка находится в четверти 2";
    if (paramX < 0 && paramY < 0) return "Точка находится в четверти 3";
    if (paramX > 0 && paramY < 0) return "Точка находится в четверти 4";
    else{
        return "Введены неправильные значения";
    }
    
}

string result = Quarter (paramX, paramY);
System.Console.WriteLine (result);
