// Напишите программу, которая на вход получает число N, а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
int num0 = 1;

while (num0 <= num)
{
    if (num0%2 == 0)
    {
        Console.WriteLine(num0);
    }
num0 ++;
}