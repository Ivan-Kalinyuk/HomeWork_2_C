Console.Write("Введите число от 1 до 7 (1 - пн, 2 - вт, 3 - ср, 4 - чт, 5 - пт, 6 - сб, 7 - вс) = ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 6) Console.WriteLine("Выбранный Вами день - будний");
if (a > 5) Console.WriteLine("Выбранный Вами день - выходной");
