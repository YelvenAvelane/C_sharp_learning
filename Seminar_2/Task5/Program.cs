// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого и наоборот

Console.Write("Вввдите первое число: ");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);

Console.Write("Вввдите второе число: ");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);

if (numq*num1==num2 || num2*num2==num1)
{
    Console.WriteLine("Одно число являестя квадратом другого")
}
else
{
    Console.WriteLine("Одно число НЕ являестя квадратом другого")
}

// Иной вариант
// if (num1*num1==num2)
// {
//     Console.WriteLine($"Число {num2} является квадратом числа {num1}");
// }
// else
// {
//     Console.WriteLine($"Число {num2} НЕ является квадратом числа {num1}");
// }

// if (num2*num2==num1)
// {
//     Console.WriteLine($"Число {num1} является квадратом числа {num2}");
// }
// else
// {
//     Console.WriteLine($"Число {num1} НЕ является квадратом числа {num2}");
// }