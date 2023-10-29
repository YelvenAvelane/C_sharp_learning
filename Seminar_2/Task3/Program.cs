// Напишите программу, которая принимает на вход два числа и выводить является ли второе число кратным первому или нет

Console.Write("Введите первое число: ");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);

Console.Write("Введите второе число: ");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);

if (num2 % num1 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {num2 % num1}");
}