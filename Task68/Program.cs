Console.WriteLine("Введите число m:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число n:");
int N = int.Parse(Console.ReadLine());

int AckermannFunction (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermannFunction(M - 1, 1);
    if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
return AckermannFunction(M, N);
}

Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckermannFunction(M, N)}");