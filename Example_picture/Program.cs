// Как преедставить черно - белое изображение
// int[,] pic = new int[23,25];
// 0 - закрашенный пикксель
// 1 - незакрашенный пиксель
// как закрасить область?
void PrintImage(int[,]image) // печатает матрицу
{
 for (int i = 0; i < image.GetLength(0);i++)// строки
{
    for (int j = 0; j < image.GetLength(1); j++) // столбцы
    {
        // Console.Write($"{image[i, j]} ");
        if (image[i,j] == 0) Console.Write($" ");
        else Console.Write($"+");

    }   


    Console.WriteLine();
}
}