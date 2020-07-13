using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("enter a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b=");
            b = Convert.ToInt32(Console.ReadLine());
            a = a * b;    
            b = a / b;      
            a = a / b;    
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}
