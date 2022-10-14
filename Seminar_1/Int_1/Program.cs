// Програвмма, которая принимает на вход два числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите число №1...");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2...");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
{
 Console.WriteLine($"True: Чсло А = {numberA} является квадратом B = {numberB}");
}
 else
{
 Console.WriteLine($"False: Число A ={numberA} НЕ является квадратом B = {numberB}");
}