// ЗАДАЧА 1
// int [] array = new int [5];
// array[0] = int.Parse(Console.ReadLine());
// array[1] = int.Parse(Console.ReadLine());
// array[2] = int.Parse(Console.ReadLine());
// array[3] = int.Parse(Console.ReadLine());
// array[4] = int.Parse(Console.ReadLine());

// Console.Write("{0}", string.Join("\n", array));

// ЗАДАЧА 2
// int[] array = {3,6,2,88,31};

// for (int i = 4; i >= 0 ; i--)
// {
//     Console.WriteLine(array[i]);
// }

// ЗАДАЧА 3
int[] array = {5,6,2,89,31};
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        sum=sum+i;
    }
}
Console.WriteLine(sum);