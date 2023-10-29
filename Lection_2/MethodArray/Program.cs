int [] array = {1,12,31,4,15,16,17,18};

int n = array.Length; //Length возвращает длину/количество массива
int find = 18;
int index = 0;

while(index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // остановит цикл и консоль выведет только первый элемент (если их несколько одинаковых)
    }
    index++;
}
// если несколько одинаковых элементов, то консоль выведет их все по порядку