using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayaConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             string name;
             name = "Jayavel";
             Console.writeLine("Your name");
           name= Console.ReadLine();

             Console.WriteLine(name);
            */

            /*
            int age;
            age = 10;
            Console.WriteLine(age+"  "+"123");
            Console.ReadLine();

            string name;
            Console.WriteLine("Enter  :");
            name = Console.ReadLine();

            Console.WriteLine(name);
            Console.ReadLine();

            */

            //tested on git



            int a = 1;

            if (a >= 2)
            {
                Console.WriteLine("mairru da ");
                Console.ReadLine();

            }


            else if (a >= 5)
            {
                Console.WriteLine("else if ");
                Console.ReadLine();

            }


            else
            {
                Console.WriteLine("summa");
                Console.ReadLine();
            }




            string result = (a > 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
            Console.ReadLine();


            switch (a)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("tursday");
                    break;

            }



            while (a <= 2)
            {
                Console.WriteLine("While loop");
                Console.ReadLine();


                a++;
            }




        }
    }
}
