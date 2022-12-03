Console.WriteLine("Введите любое число");
int N = Convert.ToInt32(Console.ReadLine());
if (N % 7 ==0)
{
    if (N % 23 ==0)
    {
        Console.WriteLine("Число кратно 7 и 23");
    }
    else
    {
        Console.WriteLine("Число не кратно 7 и 23");
    }
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}
