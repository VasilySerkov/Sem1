double[,] FillMatrix(int m, int n, int LRange, int RRange)
{
    double[,] Mtrx = new double[m,n];
    Random rand = new Random();
    for(int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
       {
        Mtrx[i,j] = rand.Next(LRange, RRange + 1) + Math.Round(rand.NextDouble(), 1);
       }
    }
    return Mtrx;
}

void PrintMatrix(double[,] Mtrx)
{
for (int i = 0; i < Mtrx.GetLength(0); i++)
    {
    Console.WriteLine();
    for (int j = 0; j < Mtrx.GetLength(1); j++)
            {
            Console.Write("{0,8}", Mtrx[i, j]);
            }
    }
}

Console.WriteLine("Введите количество строк создаваемого массива:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов создаваемого массива:");
int N = Convert.ToInt32(Console.ReadLine());
double[,] Table = FillMatrix(M, N, -99, 99);
PrintMatrix(Table);