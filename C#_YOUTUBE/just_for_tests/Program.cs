int[] array = { 3, 116, 3, 2, 45, 2, 89 };
int[] result = array.Where(i => i < 70).ToArray();
Console.WriteLine(result);
Console.ReadLine();