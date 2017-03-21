using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = ("Hello World!");
            int columbusYear = 1492;
            bool dog = true;
            DateTime theDate = new DateTime (2017, 3 , 21);
            double cheeseBurger = 5.45;
            char theSpot = ('X');


            Console.WriteLine(helloWorld);
            Console.WriteLine("Columbus Sailed the world in " + columbusYear);
            Console.WriteLine("It is " + dog + " that I have a dog at home.");
            Console.WriteLine("Today is " + theDate);
            Console.WriteLine("I spent $" + cheeseBurger + " on a cheeseburger");
            Console.WriteLine(theSpot + " marks the spot");



        }
    }
}
