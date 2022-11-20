// упорядочить массив по порядку от минимального к максимальному
// 1 найти позицию минимального элемента
// произвести обмен этого значения со значением неотсортированной позиции
// повторять пока есть неостортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)// ищет максимальный элемент
    {
        if (array[j] < array[minPosition]) 
        {
            minPosition = j;
        }
    }
        int temporary = array[i]; // производится замена элемента
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }

}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);