// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Write("Вввдите число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num<100)
{
    Console.WriteLine("Третьей цифры нет");
}
Console.WriteLine(strNum[2]);

// Так себе способ наверное. В теории можно оставить 3 строчки, но при вводе числа <100 или букв, не будет выводиться ошибка о некорректности ввода

// Console.Write("Вввдите число: ");
// string strNum = Console.ReadLine();
// Console.WriteLine(strNum[2]);