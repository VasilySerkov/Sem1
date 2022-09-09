int[,] FillMatrix(int m, int n, int LRange, int RRange)
{
    Random rand = new Random();
    int[,] Mtrx = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Mtrx[i, j] = rand.Next(LRange, RRange + 1);
        }
    }
    return Mtrx;
}

void PrintMatrix(int[,] Mtrx)
{
    for (int i = 0; i < Mtrx.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Mtrx.GetLength(1); j++)
        {
            Console.Write("{0}\t", Mtrx[i, j]);
        }
    }
}

int[,] DescedingByRows(int[,] Mtrx)
{
    for (int i = 0; i < Mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < Mtrx.GetLength(1); j++)
        {
            int maxIndex = j;
            for (int k = j + 1; k < Mtrx.GetLength(1); k++)
            {
                if (Mtrx[i, k] > Mtrx[i, maxIndex])
                {
                    maxIndex = k;
                }
            }
            int temp = Mtrx[i, j];
            Mtrx[i, j] = Mtrx[i, maxIndex];
            Mtrx[i, maxIndex] = temp;
        }
    }
return Mtrx;
}


    Console.WriteLine("Введите количество строк создаваемого массива:");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов создаваемого массива:");
    int N = Convert.ToInt32(Console.ReadLine());
    int[,] Table = FillMatrix(M, N, 0, 99);
    Console.WriteLine("Исходная матрица:");
    PrintMatrix(Table);
    DescedingByRows(Table);
    Console.WriteLine();
    Console.WriteLine("Итоговая матрица:");
    PrintMatrix(Table);