Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int i = 1;
int C = 1;
while (i <= B){
C = C*A;
i++;
}
Console.WriteLine($"A в степени B равно {C}");