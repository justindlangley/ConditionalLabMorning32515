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

            //var time = System.DateTime.Now;

            //int myTime = (System.DateTime.Now.Second);
            //Console.WriteLine(myTime);



            //I wrote this small script to test the behavior
            //by being able to manually enter values for the seconds
            //rather than having to wait for the clock to get to the 
            //quarter intervals.
            //Console.WriteLine("Please enter an integer value:");
            //string userValue = Console.ReadLine();
            //var myTime = int.Parse(userValue);

            //if (myTime == 0)
            //{ Console.WriteLine("The new minute is just beginning");
            //  Console.ReadLine();
            //}
            //if (myTime == 15)
            //{
            //    Console.WriteLine("We're one quarter done.");
            //    Console.ReadLine();
            //}
            //if (myTime == 30)
            //{
            //    Console.WriteLine("Halfway there.");
            //    Console.ReadLine();
            //}
            //if (myTime == 45)
            //{
            //    Console.WriteLine("Getting close to done");
            //    Console.ReadLine();
            //}
            //else
            //{ Console.WriteLine("Working on it...");
            //  Console.ReadLine();
            //}

            //FIZZ BUZZ

            for (var x = 1; x <= 100; x++)
            {
               
                if (x % 3 == 0)
                { Console.WriteLine("Fizz"); }

                if (x % 5 == 0)
                { Console.WriteLine("Buzz"); }

                if (x % 3 == 0 && x % 15 == 0)
                { 
                    
                    Console.WriteLine("FizzBuzz"); }

                else
                { Console.WriteLine(x); }
                

            }

            //REVERSE

            //string message = "This is a string";

            //char[] array = message.ToArray();
            //Array.Reverse(array);
            //Console.WriteLine(array);

            //EXTRA CREDIT


            //char[] testarray1 = x.ToArray(testarray); 
            //char[] testarray2 = y.ToArray();    
            //char[] testarray3 = z.ToArray();
            //Array.Reverse(testarray1; testarray2; testarray3);
            //Console.WriteLine(testarray1);
            //Console.WriteLine(testarray2);
            //Console.WriteLine(testarray3);







            //Console.ReadLine();

            //Bill example

            //foreach (var item in args)
            //{
            //    Console.WriteLine(item);
            //    for (int i = 0; i < item.Length; i++)
            //        Console.WriteLine("\t{0}", item[i]);
            //}

            //while (args.Length > 0)
            //{
            //    Console.WriteLine(args[0]);
            //    int index = 0;
            //    do
            //    {
            //        Console.WriteLine("\t{0}", args[0][index++]);
            //    } while (index < args[0].Length);
            //    args = args.Skip(1).ToArray();
            //}

            //skips first element of array and returns the rest of it

            //EXTRA CREDIT

            //string one = "Hello";
            //string two = "Goodbye";
            //char[] array1 = one.ToCharArray();
            //char[] array2 = two.ToCharArray();
            //Array.Reverse(array1);
            //Array.Reverse(array2);
            //string revone = new string(array1);
            //string revtwo = new string(array2);

            //string [] lastarray = {revtwo, revone};
            //foreach (var item in lastarray)
            //{
            //    Console.WriteLine(item);
            //}




            //string[] multstrarray = {"Hi", "Bye", "Cya"};
            //char[] array2 = multstrarray.ToCharArray();

            //string newString = 



            //foreach (string i in multstrarray)
            //{
            //    for (int j = 0; j <= i.Length - 1; j--)

            //    //char[] array = message.ToArray()
                
            //        Console.WriteLine("{0}", "{1}", "{2}", multstrarray[j]);
            //}

            
            Console.ReadLine();
        }
    }
}
    
