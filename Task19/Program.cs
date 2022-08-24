int A;
Console.WriteLine("Введите пятизначное число: ");
A = Convert.ToInt32(Console.ReadLine());
if(A < 10000 || A > 99999){
    Console.WriteLine ("Введённое число не является пятизначным");
}
else{
string ? B = Convert.ToString(A);
if(B[0] == B[4] && B[1] == B[3]) {
    Console.WriteLine("Введённое число является палиндромом");
}
else {
    Console.WriteLine("Введённое число не является палиндромом");
}
}