// Напишите, программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
// Например
// a = 3, b = 7, c = 2 - > max = 7

Console.Write("Введите первое число: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Введите второе число: ");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);

Console.Write("Введите третье число: ");
string strNum3 = Console.ReadLine();
int num3 = int.Parse(strNum3);

if (num1>num2 && num1 > num3)
{
    Console.Write("max = ");
    Console.WriteLine(num1);
}
else if (num2>num1 && num2 > num3)
{
    Console.Write("max = ");
    Console.WriteLine(num2);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(num3);
}