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
int[] SummByRows(int[,] Mtrx, int[]Sum)
{
for (int i = 0; i < Mtrx.GetLength(0); i++)
{
   Sum[i] = 0; 
   for (int j = 0; j < Mtrx.GetLength(1); j++)
   {
    Sum [i] = Sum[i] + Mtrx[i, j];
}
}
return Sum;
}
void FindMin(int[] Arr)
{
int min = Arr[0];
int indexMin = 0;
for(int k = 1; k < Arr.Length; k++)
if(Arr[k] < min)
{
    min = Arr[k];
    indexMin = k;
}
Console.WriteLine ($"{indexMin + 1}-я строка в архиве имеет наименьшую суммой элементов: {min}");
}


Console.WriteLine("Введите количество строк создаваемого массива:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов создаваемого массива:");
int N = Convert.ToInt32(Console.ReadLine());
int[,] Table = FillMatrix(M, N, 0, 99);
PrintMatrix(Table);
Console.WriteLine();
int[] Summa = new int [M];
SummByRows(Table, Summa);
FindMin(Summa);