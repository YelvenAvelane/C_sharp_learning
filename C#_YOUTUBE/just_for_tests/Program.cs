Console.Write("Введите высоту треугольника: ");
int height = int.Parse(Console.ReadLine());

// Треугольник 1

for (int i = 0; i <= height; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    } 
    Console.WriteLine();
}

Console.WriteLine();

// Треугольник 2

for (int i = 0; i < height; i++)
{
    for (int j = height; j > i; j--)
    {
        Console.Write("*");
    } 
    Console.WriteLine();
}

Console.WriteLine();

// Треугольник 3
for (int i = 0; i <= height; i++)
{
    for (int j = height; j > i; j--)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    } 
    Console.WriteLine();
}

Console.WriteLine();

// Треугольник 4

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    } 
    for (int j = height; j > i; j--)
    {
        Console.Write("*");
    } 
    Console.WriteLine();
}