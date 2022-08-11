Console.Write("Введите любое натуральное число = ");
int a = Convert.ToInt32(Console.ReadLine());
int res1 = a;
if (a<100) 
{
    Console.Write("Третьей цифры нет ");
}
else
{
    while (res1 > 999 )
    {
        res1 = res1/10;
    }
    int rem1 = res1 % 10;
    Console.Write("Третья цифра Вашего числа = ");
    Console.WriteLine(rem1);
}

 
