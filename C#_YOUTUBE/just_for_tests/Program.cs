Console.Write("Введите число: ");
string strNum = Console.ReadLine(); 
double num = double.Parse(strNum);

if (num%2 == 0)
{
Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("НЕчётное");
}


