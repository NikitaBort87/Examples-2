﻿// string[,] table = new string[2, 5];
 // String.Empty       по умолчаанию строки ничего не содержат
// table[0,0] table[0,1] table[0,2] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,4]
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2;rows++)// строки
// {
//     for (int columns = 0; columns < 5; columns++) // столбцы
//     {
//         Console.WriteLine($"-{table[rows, columns]}- ");
//     }
//}
void PrintArray(int[,]matr) // печатает матрицу
{
 for (int i = 0; i < matr.GetLength(0);i++)// строки
{
    for (int j = 0; j < matr.GetLength(1); j++) // столбцы
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
}
}

void FillArray(int[,] matr)//Заполняет матрицу случайными числами
{
     for (int i = 0; i < matr.GetLength(0);i++)
{
    for (int j = 0; j < matr.GetLength(1); j++) 
    {
        matr[i,j] = new Random().Next(1, 10); //[1,10]
    }
}
}
int [,] matrix = new int[ 3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
