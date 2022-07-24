// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = new int [,] {
{10, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 3, 4},
{5, 2, 6, 7}
};

void MinSumLineMtrx(int[,] mtrx)
{
    Console.Write("Номер строки с наименьшей суммой элементов: ");
    int min = 0;
    int sum;
    int numberLine = 1;
    for (int i = 0; i < mtrx.GetLength(1); i++)
    {
        min += mtrx[0,i];
    }
    for (int i = 1; i < mtrx.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            sum += mtrx[i,j];
        }
        if(min > sum) 
        {
            min = sum;
            numberLine = i + 1;
        }
    }
    for (int i = 1; i < mtrx.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            sum += mtrx[i,j];
        }
        if(min == sum) 
        {
            Console.Write($"{i + 1}");
            if (i < numberLine) Console.Write(", ");
            else Console.Write(" строка");
        }
    }
}

MinSumLineMtrx(matrix);