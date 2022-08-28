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

void SummNE(int[] ary, out int Sum)
{
    Sum = 0;
    for (int j = 0; j < ary.Length; j += 2)
        {
        Sum += ary[j];
        }
}

int[] Array = FillArray(7, 0, 99);
SummNE(Array, out int S);
Console.WriteLine('[' + string.Join(", ", Array) + ']');
Console.WriteLine($"Сумма элементов на нечётных позициях = {S}");