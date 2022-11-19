using System;
class Project
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter one number :");
        string a1 = Console.ReadLine();
        double x = Convert.ToDouble(a1);
        Console.WriteLine("power 2 number " + x + " is " + tavan(x));
        Console.ReadKey();
    }
    private static double tavan(double x)
    {
        double w = x * x;
        return w;
    }
}//برنامه ای بنویسید ک عددی را خوانده و توان دو عدد را در تابع نشان دهد
