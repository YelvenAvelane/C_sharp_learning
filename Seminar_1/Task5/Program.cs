// Напишите программу, которая на вход принимает 3-х значное число, а на выходе показывает последнюю цифру этого числа
// Например 
// 456 -> 6

Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
// Аналогом предыдущих двух строчек будет строчка
//int num = int.Parse(Console.ReadLine());"

if (num >= 100 && num <= 999)
{
    Console.WriteLine(num%10);
}
else
{
    Console.WriteLine("Некорректное число");
}