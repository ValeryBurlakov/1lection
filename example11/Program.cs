void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++; // void метод, метод, который ничего не возвращает в отличие от return
    }
}
  
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // вместо 0 ставим -1, чтобы если не было элемента в массиве, было -1 в консоли
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;

        }
        index++;
        
    }
    return position;// с этим методом получили индекс последнего искомого элемента
}
  //метод, отличный от void
    // return, мы использовали void метод, как в поиске максимума из 3
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }
int[] array = new int[10]; // int new[10] создаём массив с 10 элементами, который будет наполнен нулями

FillArray(array);//метод, который заполнил массив
array[4] = 4;// искуственно добавили
array[6] = 4;// 4 в массив
PrintArray(array);//метод, который нам распечатал массив
Console.WriteLine();

int pos = IndexOf(array, 42);//если икасть элемент, которого нет в массиве, он выводи 0, якобы элемент с индексом 0
Console.WriteLine(pos);
