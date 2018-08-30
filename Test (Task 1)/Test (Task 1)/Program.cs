using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__Task_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;                 //this is the variable 

            Console.WriteLine("Please Enter The Number Between 1 and 1000");    //this is the computer wanting user input
            number1 = Convert.ToInt32(Console.ReadLine());                     

            for (int i = number1; i <= 1000; i++)
            {
                Console.WriteLine("{0} Is a Odd Number",number1);               //ive forgotten the formula to the use modulist all i can remember is  
                break;                                                          // this instantly makes it go to the next block of code
            }

            Console.WriteLine();
            

            
            
        }
    }
}
