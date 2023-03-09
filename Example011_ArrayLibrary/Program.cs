void FillArray(int[]collection)// заполнили его случайными числами
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)// распечатали массив
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10]; // создали массив из 10 элементов

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while( index <count)
    {
        if(collection[index]==find)
        { 
            position = index;
            break;
        }
        index++;

    }
    return position;

}
FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
System.Console.WriteLine();
int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);