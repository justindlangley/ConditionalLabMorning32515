using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLabMorning32515
{
    class Program
    {
        static void Main(string[] args)
        {

            //define variables
            //Console.WriteLine("Please enter the amount of your income: ");

            //var userValue = Console.ReadLine();
            //var income = int.Parse(userValue);
            //var tax5 = (income * 0.05);
            //var tax10 = (income * 0.10);
            //var tax20 = (income * 0.20);
            //var tax35 = (income * 0.35);

            //if (income <= 20000)
            //{ Console.WriteLine("Your total amount of tax = {0}", tax5);
            //Console.ReadLine();
            //    return;
            //}
            
            //if (income > 20000)
            //{Console.WriteLine("Your total amount of tax = {0}", tax10);
            //Console.ReadLine();
            //return;}
            
            //if (income > 50000)
            //{Console.WriteLine("Your total amount of tax = {0}", tax20);
            //Console.ReadLine();
            //return;}

            //if (income > 75000)
            //{
            //    Console.WriteLine("Your total amount of tax = {0}", tax35);
            //    Console.ReadLine();
            //    return;
            //}

            //else
            //{
            //    Console.WriteLine("Sorry, you did not enter a valid income amount.");
            //    Console.ReadLine();
            //}

            //TIME PROBLEM

            var time = System.DateTime.Now;

            int myTime = (System.DateTime.Now.Second);
            Console.WriteLine(myTime);



            //I wrote this small script to test the behavior
            //by being able to manually enter values for the seconds
            //rather than having to wait for the clock to get to the 
            //quarter intervals.
            //Console.WriteLine("Please enter an integer value:");
            //string userValue = Console.ReadLine();
            //var myTime = int.Parse(userValue);

            if (myTime == 0)
            { Console.WriteLine("The new minute is just beginning");
              Console.ReadLine();
            }
            if (myTime == 15)
            {
                Console.WriteLine("We're one quarter done.");
                Console.ReadLine();
            }
            if (myTime == 30)
            {
                Console.WriteLine("Halfway there.");
                Console.ReadLine();
            }
            if (myTime == 45)
            {
                Console.WriteLine("Getting close to done");
                Console.ReadLine();
            }
            else
            { Console.WriteLine("Working on it...");
              Console.ReadLine();
            }
            












            Console.ReadLine();

        }
    }
}
