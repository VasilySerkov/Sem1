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

void PrintMatrix(int [,] Mtrx)
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

void FindElement(int[,] Mtrx, int x, int y)
{
if(x < Mtrx.GetLength(0) && y < Mtrx.GetLength(0))
{
    Console.WriteLine($"Искомый элемент = {Mtrx[x-1, y-1]}");
}
else
{
    Console.WriteLine("Такого элемента в массиве нет");
}
}

int[,] Table = FillMatrix(7, 9, 0, 99);
PrintMatrix(Table);
Console.WriteLine();
Console.WriteLine("Введите номер строки искомого элемента массива:");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца искомого элемента массива:");
int Y = Convert.ToInt32(Console.ReadLine());
FindElement(Table, X, Y);