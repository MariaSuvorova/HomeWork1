/* Задача 6: Напишите программу, которая на вход принимает число и 
выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);

int evennumber = a%2;
if (evennumber == 0)
{
Console.WriteLine($"Число {a} четное");
}
else 
Console.WriteLine($"Число {a} нечетное");
