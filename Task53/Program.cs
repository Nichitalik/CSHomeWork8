// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


int[,] matrix = new int [3, 4] {
    {1, 2,  3,  4},
    {5, 6,  7 , 8},
    {9, 10, 11, 12}
};

void ShowMatrix (int[,] value)
{
    for (int i = 0; i < value.GetLength(0); i++)
    {
        for (int j = 0; j < value.GetLength(1); j++)
        {
            if(j == 0) Console.Write(" | ");
            Console.Write($"{value[i, j], 3} | ");
        }
        Console.WriteLine();
    }
}

int[,] Replace(int[,] mtrx){
    int [] help = new int [mtrx.GetLength(1)];
    for (int i = 0; i < mtrx.GetLength(1); i++)
    {
        help[i] = mtrx[0, i];
        mtrx[0, i] = mtrx[mtrx.GetLength(0) - 1, i];
        mtrx[mtrx.GetLength(0) - 1, i] = help[i];
    }

    return mtrx;
}

ShowMatrix(matrix);
Console.WriteLine();
ShowMatrix(Replace(matrix));
