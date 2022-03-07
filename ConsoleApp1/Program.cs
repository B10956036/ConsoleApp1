using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_csot = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            double a = meal_csot * tip_percent / 100+ tax_percent*meal_csot   / 100+meal_csot ;
            Console.WriteLine("total:"+a);
            
        }
    }
}
