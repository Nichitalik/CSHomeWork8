// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)


int[,,] arr= new int[2, 2, 2] {
{{1,2},{3,4}},
{{5,6},{7,8}}
};

void Print3DArr(int[,,] value)
{
    for (int j = 0; j < value.GetLength(1); j++)
    {  
        for (int i = 0; i < value.GetLength(0); i++)
        {
            for (int k = 0; k < value.GetLength(2); k++)
            {
                Console.Write($"{value[i,j,k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

Print3DArr(arr);