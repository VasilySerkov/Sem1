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

void CountEven(int[] ary, out int Even)
{
    Even = 0;
    for (int j = 0; j < ary.Length; j++)
    {
        if (ary[j] % 2 == 0)
        {
        Even += 1;
        }
    }
}

Console.WriteLine("Введите количество элементов массива:");
int N = Convert.ToInt32(Console.ReadLine());
int[] Array = FillArray(N, 100, 999);
CountEven(Array, out int E);
Console.WriteLine('[' + string.Join(", ", Array) + ']');
Console.WriteLine($"Количество чётных чисел массива = {E}");