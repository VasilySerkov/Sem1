Console.WriteLine("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int M = N / 10 % 10;
Console.WriteLine(M);
// альтернативное решение
// Console.WriteLine("Введите трехзначное число: ");
// string ? s = Convert.ToString(Console.ReadLine());
// int N = int.Parse(s[1].ToString());
// Console.WriteLine(N);