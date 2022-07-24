// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49



int[,] A = new int [,] {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
};

int[,] B = new int [,] {
    {1, 5, 8, 5},
    {4, 9, 4, 2},
    {7, 2, 2, 6},
    {2, 3, 4, 7}
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

int[,] MatrixMultiplication(int[,] A, int[,] B) // Правильное матричное умножение!!!
{
    int[,] result = new int [B.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        { 
            for (int k = 0; k < A.GetLength(1); k++)
            {
                result[i,j] += A[i,k] * B[k, j];
            }
        }
    }
    return result;
}

int[,] MultiplicationMatrixElement(int[,] A, int[,] B)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i,j] *= B[i,j];
        }
    }
    return A;
}

System.Console.WriteLine("Матрица А:");
ShowMatrix(A);
System.Console.WriteLine();
System.Console.WriteLine("Матрица B:");
ShowMatrix(B);
System.Console.WriteLine();
if (A.GetLength(1) == B.GetLength(0))
{
    System.Console.WriteLine("Правильное матричное умножение:");
    ShowMatrix(MatrixMultiplication(A, B));
}
else System.Console.WriteLine("размеры матриц не соответствуют условию");
System.Console.WriteLine();
if (A.GetLength(0) == B.GetLength(0))
{
    if (A.GetLength(1) == B.GetLength(1))
    {
        System.Console.WriteLine("Умножение элементов матриц:");
        ShowMatrix(MultiplicationMatrixElement(A,B));
    }
}
else System.Console.WriteLine("размеры матриц не соответствуют условию");
