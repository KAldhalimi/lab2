using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlcome to Grand Circus' room detail Generator");
            Console.Write("Please write the length of your Room: ");
            decimal lengthSide = decimal.Parse(Console.ReadLine());
            Console.Write("Please write the width of your Room: ");
            decimal widthSide = decimal.Parse(Console.ReadLine());

            decimal area = lengthSide * widthSide;
            decimal perimeter = 2 * (widthSide + lengthSide);


            Console.WriteLine("The area of your Room is: {0}", area);
            Console.WriteLine("the perimeter of your room is: {0}", perimeter);

            Console.WriteLine("would you like to continue? (Y,N)");
            string input = Console.ReadLine();
            
            

            
            Console.ReadKey();
        }
    }
}
            
        
     
