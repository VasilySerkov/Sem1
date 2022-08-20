Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
string ? M = Convert.ToString(N);
if (N <= 99) {
    Console.WriteLine("Третьей цифры нет");
}
else {
int Number = int.Parse(M[2].ToString());
Console.WriteLine(Number);
}
