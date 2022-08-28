int[] FillArray(int size, int LRange, int RRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(LRange, RRange + 1);
    }
    return arr;
}

void FindRange(int[] ary, out int Range)
{
    Range = 0;
    for (int j = 0; j < ary.Length; j++)
    {
        if (ary[j] >= 10 && ary[j] <=99)
        {
        Range += 1;
        }
    }
}

int[] Array = FillArray(123, 0, 999);
FindRange(Array, out int N);
Console.WriteLine('[' + string.Join(", ", Array) + ']');
Console.WriteLine($"Количество чисел массива в отрезке [10, 99] = {N}");