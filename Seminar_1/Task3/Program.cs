// Напишите программу, которая будет выдавать название дня недели по заданному номеру
// Например
// 3 -> Среда
// 5 -> Пятница
// и т.д.


Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int dayNum = int.Parse(strNum); // Эта строка не обязательна. Вместо неё можно числа в ветвлениях записать в кавычки. Например: if (dayNum == "1"). Тот же результат.

if (dayNum == 1)
{
    Console.WriteLine("Понедельник");
}
else if (dayNum == 2) // Если не вводить "else if" и оставить далее везде просто "if", то консоль выдаст день недели (например Суббота), но так же и фразу "Некорректное число".
{
    Console.WriteLine("Вторник");
}
else if (dayNum == 3)
{
    Console.WriteLine("Среда");
}
else if (dayNum == 4)
{
    Console.WriteLine("Четверг");
}
else if (dayNum == 5)
{
    Console.WriteLine("Пятница");
}
else if (dayNum == 6)
{
    Console.WriteLine("Суббота");
}
else if (dayNum == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Некорректное число");
}