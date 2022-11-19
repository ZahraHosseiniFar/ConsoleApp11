using System;
    class Project
    {
       public static void Main(string[] args)
        {
        Console.WriteLine("enter one number : ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("the square root of " + a + " is : " + f(a));
        Console.ReadKey();
        }
       private static double f(double x)
    {
        x = Math.Sqrt(x);
        return x; 
    }
    }//برنامه ای بنویسید ک ریشه دوم عدد را نمایش دهد

