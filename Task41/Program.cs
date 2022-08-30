// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива №{i+1}");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PositivCount(int[] ary, out int Count)
{
    Count = 0;
    for (int j = 1; j < ary.Length; j++)
        {
        if(ary[j] > 0)
        {
            Count++;
        }
        }
}

Console.WriteLine("Введите количество элементов массива:");
int N = Convert.ToInt32(Console.ReadLine());
int[] Array = FillArray(N);

PositivCount(Array, out int Ct);
Console.WriteLine('[' + string.Join(", ", Array) + ']');
Console.WriteLine($"Количество положительных чисел массива = {Ct}");