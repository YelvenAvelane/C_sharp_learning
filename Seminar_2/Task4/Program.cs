// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно числам 7 и 23 (в данном случае это число 161)

Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int a = 7;
int b = 23;

if (num % a == 0 && num % b == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}