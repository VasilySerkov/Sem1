Console.WriteLine("Введите любое целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
if (N == 0){
    Console.WriteLine("0");
}
else{
    int count = 1;
    while(count <= N){
Console.WriteLine(Math.Pow(count, 3));
count++;
    }
}