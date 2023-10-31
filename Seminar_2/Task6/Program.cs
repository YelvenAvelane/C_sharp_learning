//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Вввдите число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);


if (num > 999 || num < 100)
{
    Console.WriteLine("Не корректное число");
}
else
{
int result = (num % 100) / 10; 
// т.к. тип данных int, то в ответе будет учитываться только целое число (например если ввели 458, то в математике будет ответ = 5.8, но т.к. у нас int, то ответ = 5)

Console.WriteLine(result);
}

// Ещё несколько грубых вариантов else

// int num1 = num % 10;
// int num2 = num-num1;
// int num3 = num2/10;
// int result = num3 % 10;
// Console.WriteLine(result);

// Ещё один вариант else

// int num1 = num % 10;
// num = num-num1;
// int result = (num% 100) / 10;
// Cosole.WriteLine(result);