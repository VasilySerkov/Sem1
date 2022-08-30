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

int[] CopyArray(int[] arrInit, int[] arrCopy)
{
    for (int j = 0; j < arrInit.Length; j++)
    {
        arrCopy[j] = arrInit[j];
    }
    return arrCopy;
}

Console.WriteLine("Введите количество чисел массива:");
int N = Convert.ToInt32(Console.ReadLine());
int[] Array = FillArray(N, 0, 99);
Console.WriteLine("Начальный массив:");
Console.WriteLine('[' + string.Join(", ", Array) + ']');
int[] Array2 = new int[N];
CopyArray(Array, Array2);
Console.WriteLine("Копия массива:");
Console.WriteLine('[' + string.Join(", ", Array2) + ']');