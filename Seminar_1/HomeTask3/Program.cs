// Напишите программу, которая на вход принимает число и выдаёт, является ли оно чётным или нет

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num%2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}