using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? "); //getting first name, put Write so it stays on the same line, savinf name to variable firstName
            string firstName = Console.ReadLine();
           
            Console.Write("What is your last name? "); //getting the last name, saving to variable lastName
            string lastName = Console.ReadLine();

            Console.Write("What is your age? "); //getting age, saving to variable age. Didn't know if string was acceptable but it works so i kept it.
            string age = Console.ReadLine();

            Console.Write("What is your favorite color? ");  //getting color, saving to variable favoriteColor
            string favoriteColor = Console.ReadLine();

            Console.WriteLine("Hello, " +firstName +" "+ lastName +"! You are " + age + " years old and your favorite color is " + favoriteColor); //putting all the variables together
            Console.ReadLine();
        }
    }
}
