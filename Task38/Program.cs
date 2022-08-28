double[] FillArray(int size, int LRange, int RRange)
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива №{i+1}");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

void MinMax(double[] ary, out double Min, out double Max)
{
    Min = ary[0];
    Max = ary[0];
    for (int j = 1; j < ary.Length; j++)
        {
        if(ary[j] > Max)
        {
            Max = ary[j];
        }
        if(ary[j] < Min)
        {
            Min = ary[j];
        }
        }
}

Console.WriteLine("Введите количество элементов массива:");
int N = Convert.ToInt32(Console.ReadLine());
double[] Array = FillArray(N, 0, 999);
MinMax(Array, out double Mn, out double Mx);
Console.WriteLine('[' + string.Join(", ", Array) + ']');
Console.WriteLine($"Разница между max и min элементами массива = {Mx-Mn}");