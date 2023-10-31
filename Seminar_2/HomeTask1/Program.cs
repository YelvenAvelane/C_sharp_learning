// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Write("Вввдите число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if (num>99 && num<1000)
    {
        int result = num % 10;
        Console.WriteLine(result);
    }
    else if (num>990 && num<10000)
    {
        int result = (num % 100) / 10;
        Console.WriteLine(result);
    }
    else if (num>9900 && num<100000)
    {
        int result = (num % 1000) / 100;
        Console.WriteLine(result);
    }
    else if (num>99000 && num<1000000)
    {
        int result = (num % 10000) / 1000;
        Console.WriteLine(result);
    }
    else if (num>990000 && num<10000000)
    {
        int result = (num % 100000) / 10000;
        Console.WriteLine(result);
    }
    else if (num>9900000 && num<100000000)
    {
        int result = (num % 1000000) / 100000;
        Console.WriteLine(result);
    }
    else if (num>99000000 && num<1000000000)
    {
        int result = (num % 10000000) / 1000000;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Очень больше число, сорян");
    }
}