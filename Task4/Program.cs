/* Задача 4: Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

Console.WriteLine("Введите третье число");
string number3 = Console.ReadLine();
int c = Convert.ToInt32(number3);

int maxnumber = a;
if (b > maxnumber)
{
maxnumber = b;
}
if (c > maxnumber)
{
maxnumber = c;
}

Console.WriteLine($"Максимальное из трех чисел {maxnumber}");