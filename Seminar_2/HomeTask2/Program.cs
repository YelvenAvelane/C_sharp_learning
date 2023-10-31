// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и првоеряет, является ли этот день выходным

Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int dayNum = int.Parse(strNum); // Эта строка не обязательна. Вместо неё можно числа в ветвлениях записать в кавычки. Например: if (dayNum == "1"). Тот же результат.

int [] weekdays = {1,2,3,4,5};
int [] weekend = {6,7};

if (weekdays.Contains(dayNum))
{
    Console.WriteLine("Будний день");
}
else if (weekend.Contains(dayNum))
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Некорректное число");
}