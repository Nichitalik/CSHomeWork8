// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


int[,] matrix = new int [,] {{1, 4, 7, 2},
                            {5, 9, 2, 3},
                            {8, 4, 2, 4}
};

void ShowMatrix (int[,] value)
{
    for (int i = 0; i < value.GetLength(0); i++)
    {
        for (int j = 0; j < value.GetLength(1); j++)
        {
            if(j == 0) Console.Write(" | ");
            Console.Write($"{value[i, j], 4} | ");
        }
        Console.WriteLine();
    }
}

int[,] SortLineArray(int[,] mtrx)
{
    int[] help = new int [mtrx.GetLength(1)];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            help[j] = mtrx[i, j];
        }
        Array.Sort(help);
        Array.Reverse(help); // убрать эту строку и строки матрицы будут по возрастанию
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            matrix[i, j] = help[j];
        }
    }
    return mtrx;
}

ShowMatrix(matrix);
System.Console.WriteLine();
ShowMatrix(SortLineArray(matrix));