// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника


void PaskalTriangle(int N)
{
    int[] oldLine = new int [] {1};
    Console.Clear();
    int x = 70, y = 1;
    Console.SetCursorPosition(x, y);
    System.Console.WriteLine(String.Join(" ", oldLine));
    int[] newLine = new int [oldLine.Length + 1];
    int difference = 2;
    for (int j = 2; j < N; j++)
    {
        newLine = new int [oldLine.Length + 1];
        for (int i = 0; i < newLine.Length; i++)
        {
            if (i == 0 || i > oldLine.Length - 1)
            {
                newLine[i] = 1;
            }
            else newLine[i] = oldLine[i - 1] + oldLine[i];
        }
        x--;
        y++;
        if (String.Join(" ", newLine).Length - String.Join(" ", oldLine).Length > difference)
        {
            difference = String.Join(" ", newLine).Length - String.Join(" ", oldLine).Length - 2;
            x -= (difference/2);
        }
        Console.SetCursorPosition(x, y);
        System.Console.WriteLine(String.Join(" ", newLine));
        oldLine = newLine;
        difference = 3;
    }
}

PaskalTriangle(24);

// int[] a = new int  [] {1, 2};
// System.Console.WriteLine(String.Join(", ", a));
// a = new int [a.Length + 1];
// a[0] = 1;
// System.Console.WriteLine(String.Join(", ", a));