// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число, умноженное само на себя)
// Например:
// 4 -> 16
// -3 -> 9
// и т.д. 

Console.Write("Введите число: ");
string strNum = Console.ReadLine(); // Мы получили введенные данные и записали в нашу переменную типа string
int num = int.Parse(strNum);  //  Parse - приобразование строки в число (  аналог Convert.ToInt32() )
int sqr = num * num;
Console.WriteLine(sqr);