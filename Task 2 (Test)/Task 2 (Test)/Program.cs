using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2__Test_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, Answer;   //these are all the variables i used n meaning number 

            Console.WriteLine("Please Enter The First Number"); 
            n1 = Convert.ToInt32(Console.ReadLine());              //n1 = number1 etc

            Console.WriteLine("Please Enter The Second Number");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Third Number");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Fourth Number");
            n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Fifith Number");
            n5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The sixth Number");
            n6= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Seventh Number");
            n7= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Eigth  Number");
            n8= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Nineth Number");
            n9= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Tenth Number");
            n10= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Answer Is {0}",Answer);
            Answer = Convert.ToInt32(Console.ReadLine());

            Answer = n1 * n2 * n3 * n4 * n5 * n6 * n7 * n8 * n9 * n10 / 10;   //to find the average you times all numbers by themselves then divide by how many numbers were times, so 10

            Console.ReadLine();

        }
    }
}
