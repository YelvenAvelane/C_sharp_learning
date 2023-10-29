// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
// Например 94 -> 9

int num = new Random().Next (10,100);
Console.WriteLine(num);

int num1 = num / 10; // 94/10 = 9
int num2 = num % 10; // 94%10 = 4

if (num1 > num2)
{
    Console.WriteLine(num1); // Ещё рабочий вариант   Console.WriteLine("max = " + num1)
}
else
{
    Console.WriteLine(num2); // Ещё рабочий вариант   Console.WriteLine("max = " + num2)
}

// Ещё один аналог       Console.WriteLine($"max = {num1}"); // это интерполяция строк