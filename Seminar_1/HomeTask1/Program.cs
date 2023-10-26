// Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше
// Например
// a = 5, b = 7 -> max = 7

Console.Write("Введите первое число: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Введите второе число: ");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);

if (num1>num2)
{
    Console.Write("max = ");
    Console.WriteLine(num1);
    Console.Write("min = ");
    Console.Write(num2);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(num2);
    Console.Write("min = ");
    Console.Write(num1);
}