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
int[,] MatrixMultiplication(int [,] Mtrx1, int [,] Mtrx2, int [,] MtrxMltp)
{
for(int i = 0; i < Mtrx1.GetLength(0); i++)
{
    for(int j = 0; j < Mtrx2.GetLength(1); j++)
    {
        for(int k = 0; k < Mtrx1.GetLength(1); k++)
{
        MtrxMltp[i, j] += Mtrx1[i, k] * Mtrx2[k, j];
}
    }
}
return MtrxMltp;
}


    Console.WriteLine("Введите количество строк массива 1:");
    int M1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива 1:");
    int N1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество строк массива 2:");
    int M2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива 2:");
    int N2 = Convert.ToInt32(Console.ReadLine());
    int[,] Table1 = FillMatrix(M1, N1, -9, 9);
    int[,] Table2 = FillMatrix(M2, N2, -9, 9);
    Console.WriteLine("Матрица 1:");
    PrintMatrix(Table1);
    Console.WriteLine();
    Console.WriteLine("Матрица 2:");
    PrintMatrix(Table2);
    Console.WriteLine();
    if(M1 != N2 || N1!= M2)
    {
        Console.WriteLine("Данные матрицы невозможно перемножить");
    }
        else
        {
            int[,] Result = new int[M1,N2];
            MatrixMultiplication(Table1, Table2, Result);
        Console.WriteLine("Результирующая матрица:");
        PrintMatrix(Result);
        }