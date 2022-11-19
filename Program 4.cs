using System;
class Project
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter your inventory : ");
        long  a = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("enter percentage : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the goal : ");
        long  c = Convert.ToInt64(Console.ReadLine());
        money(a, b, c);
        Console.ReadKey();
    }
    private static void money(long  x, int y, long z)
    {
        int i;
        for(i=0; i>=0; i++)
        {
            x += (x * y / 100);

            if (x >= z)
            {
                Console.WriteLine("after "+i+" years,your inventory reaches "+ z);
                break;   
            }
     
        }
        
    }
}//برنامه ای بنویسید ک سود بهره سالیانه مبلغ دلخواه را محاسبه کند

 

