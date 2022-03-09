using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLib;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite kolichestvo othenok");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] marks = new string[n];
            //string [] marks1;
            Console.WriteLine("Vvedite othenki");
            for (int i = 0; i < n; i++)
            {
                marks[i] = Console.ReadLine();
            }
            double result = utils.MinAVG(marks);
            Console.WriteLine("Result: {0}", result);
            int exit = Convert.ToInt32(Console.ReadLine());
        }
    
    }
}
