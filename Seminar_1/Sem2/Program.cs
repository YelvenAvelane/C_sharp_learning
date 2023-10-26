// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// Например
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет

Console.Write("Введите первое число: ");
string firstNum = Console.ReadLine();
int num1 = int.Parse(firstNum); 
Console.Write("Введите второе число: ");
string secondNum = Console.ReadLine();
int num2 = int.Parse(secondNum);
int sqr = num1 * num1;
if (sqr == num2)
{
    Console.WriteLine(да);
}
else
{
    Console.WriteLine(нет);
}