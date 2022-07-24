// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


int[,] matrix = new int [,] {
    {1, 2,  3,  4},
    {5, 6,  7 , 8},
    {9, 10, 11, 12},
    {13, 14, 15, 16}
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

int[,] Transposition(int[,] mtrx){
    int[,] result = new int [mtrx.GetLength(0), mtrx.GetLength(1)];
    if(mtrx.GetLength(0) == mtrx.GetLength(1))
    {
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            for (int j = 0; j < mtrx.GetLength(1); j++)
            {
                result[j, i] = mtrx[i, j];
            }
        }
        return result;
    }
    else 
    {
        System.Console.WriteLine("Невозможно выполнить функцию для данной матрицы\n");
        return mtrx;
    }
}

Console.WriteLine();
ShowMatrix(Transposition(matrix));
