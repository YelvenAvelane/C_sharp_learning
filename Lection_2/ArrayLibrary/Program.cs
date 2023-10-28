// Метод заполнения массива FillArray
void FillArray(int[] collection) // collection - аргумент, придуманный нами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

// Метод вывода массива
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // , можно любое другое минус число. 
    //Если поставить 0, то в случае, если искомого числа нет в массиве, метод будет возвращать 0, так же как если бы искомое число было на первом месте (путаница)
   
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            //break; //иначе консоль модет выводить индекс последнего искомого элемента (в данном случае мы ищем 4), если есть несколько одинаковых элементов (в данном случае четверок)
            // так в массиве, в котором три четверки, консоль выведет место (индекс) последней четверки в массиве
        }
        index++;
    }
    return position;
}

int [] array = new int[10]; // По умолчанию массив будет наполнен нулями

FillArray(array);
// Искуственно добавим в массив две четвёрки
// array[4] = 4;
// array[6] = 4;
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);