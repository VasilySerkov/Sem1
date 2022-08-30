void Multiplicaton(int M, ref int Mlt)
{
    if( M <= 1) return;
        Mlt = M * Mlt;
        Multiplicaton(M-1, ref Mlt);
}

Console.WriteLine("Введите целое положительное N:");
int N = Convert.ToInt32(Console.ReadLine());
int Multipl = 1;
Multiplicaton(N, ref Multipl);
Console.WriteLine($"Произведение чисел от 1 до {N} = {Multipl}");