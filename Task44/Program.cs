Console.WriteLine("Введите целое положительное число N больше двух:");
int N = Convert.ToInt32(Console.ReadLine());
int[] Fibon = new int[N];
Fibon[0] = 0;
Fibon[1] = 1;
for (int i = 2; i < N; i++)
{
Fibon[i] = Fibon[i - 2] + Fibon[i - 1];
}
Console.WriteLine("Последовательность Фибоначчи:" + string.Join(", ", Fibon));