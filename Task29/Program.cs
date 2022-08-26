Console.WriteLine("Введите количество чисел в массиве: ");
int A = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[A];
for (int i = 0; i < A; i++)
{
    Array[i] = new Random().Next(0, 100);
}
Console.WriteLine('[' + string.Join(", ", Array) + ']');