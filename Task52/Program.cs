int[,] FillMatrix(int m, int n, int LRange, int RRange)
{
    Random rand = new Random();
    int[,] Mtrx = new int[m,n];
    for(int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
       {
        Mtrx[i,j] = rand.Next(LRange, RRange + 1);
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
double[] AverageByColumns(int[,] Mtrx, double[]Avg)
{
Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int j = 0; j < Mtrx.GetLength(1); j++)
{
   Avg[j] = 0; 
   for (int i = 0; i < Mtrx.GetLength(0); i++)
   {
    Avg [j] = Avg[j] + Mtrx[i,j];
}
Avg[j] = Avg[j] / Mtrx.GetLength(0);
Console.Write("{0}\t", Math.Round(Avg[j], 1));
}
return Avg;
}

Console.WriteLine("Введите количество строк создаваемого массива:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов создаваемого массива:");
int N = Convert.ToInt32(Console.ReadLine());
int[,] Table = FillMatrix(M, N, 0, 99);
PrintMatrix(Table);
Console.WriteLine();
double[] Average = new double [N];
AverageByColumns(Table, Average);