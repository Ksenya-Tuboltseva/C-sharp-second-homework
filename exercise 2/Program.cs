Console.WriteLine("Введите любое число"); //Программа работает для чисел меньше 10.000
int N = Convert.ToInt32(Console.ReadLine());
if (N>=100)
{
    if (N>=1000)
    {
        N = N / 10;
    }
    N = N % 10;
    Console.WriteLine("Третье число "+ N);
}
else
{
    Console.WriteLine("У числа нет третьей цифры");
}
