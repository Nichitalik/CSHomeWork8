// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


int[,] SpiralMatrix()
{
    int i = 0, j = 0;
    int[,] result = new int[4,4];
    for (int k = 1; k < result.GetLength(0) * result.GetLength(1); k++)
    {
        result[i, j] = k;
        if (i <= j + 1 && i + j < result.GetLength(1) - 1) j++;
        else if(i < j && i + j >= result.GetLength(0) - 1) i++;
        else if (i >= j && i + j > result.GetLength(1) - 1) j--;
        else i--;
    }
    return result;
}

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

ShowMatrix(SpiralMatrix());