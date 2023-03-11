// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//         return result;
// }
// Console.WriteLine(newText);
// string newText = Replace(text, ' ', '|');


// задача отсортироввать массив:
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 0, 1, 1 };
void PrintArray(int[] array)//// Метод вывода массива на экран
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)// Метод сортировки массива
{

    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

PrintArray(arr); 
SelectionSort(arr);
PrintArray(arr);

