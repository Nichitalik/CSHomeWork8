// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


int[,] matrix = new int [,] { 
    {10, 2,  3,  4},
    {5, 6,  7 , 8},
    {9, 10, 1, 12},
    {13, 14, 15, 6}
};


void ShowMatrix (int[,] value) // вывод матрицы
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

int MinElement(int[,] mtrx)// нахождение минимального по значению элемента
{
    int min = mtrx[0, 0];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if(min > mtrx[i, j]) min = mtrx[i,j];
        }
    }
    return min;
}

int[] PositionElement(int[,] mtrx, int element) // нахождение позиций элементов
{
    int[] position = new int [2];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if(mtrx[i,j] == element)
            {
                position[0] = i;
                position[1] = j;
            }
        }
    }
    return position;
}

int[,] DeleteMinKros(int[,] mtrx, int element) // удаление строк и столбцов
{
    int[] position = PositionElement(mtrx, element);
    int help;
    int[,] result = new int[mtrx.GetLength(0) - 1, mtrx.GetLength(1) - 1];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        int iDif = 0, jDif = 0;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if(position[0] == 1 & position[1] == j) 
            {
                help = mtrx[i + 1, j + 1];
                iDif++;
                jDif++;
            }
            else if (position[0] == i) 
            {
                help = mtrx[i + 1, j];
                iDif++;
            }
            else if (position[1] == j) 
            {
                help = mtrx[i ,j + 1];
                jDif++;
            }
            else help = mtrx[i+iDif, j+jDif];
            result[i,j] = help;
        }
    }
    if (mtrx[position[0], position[1]] != element) return mtrx;
    else return result;    
}


ShowMatrix(matrix);
System.Console.WriteLine();
ShowMatrix(DeleteMinKros(matrix, MinElement(matrix)));
