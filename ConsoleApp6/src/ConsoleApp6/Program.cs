using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region trash
            //var books = new BookRepo() .GetBooks();

            //var aspnetBook = books.SingleOrDefault(b=>b.Title == "mplampla");
            //Console.WriteLine(aspnetBook.Title);
            //Console.ReadLine();


            //var aspnetBook2 = books.Where(b=>b.Title == "C# Advanced Topics");
            //Console.WriteLine(aspnetBook2);
            #endregion

            #region Lesson 1 Declaring Variables
            /*
            string myLastName;
            Console.Write("Can i have your LastName aswell please ?\n");
            myLastName = Console.ReadLine();
            Console.WriteLine("What's your name?\n");
            Console.Write("Type it , dont be shy...\n");
            string myFirstname;
            myFirstname = Console.ReadLine();
            Console.WriteLine("Can i have your LastName aswell please ?\n");
            string MyLastName = Console.ReadLine();
            Console.WriteLine("Hello, \n" + myFirstname + " " + MyLastName);
            Console.ReadLine();
            */
            #endregion

            #region Lesson 2 Magic IF Game :)

            /*
            Console.WriteLine("Get a surprise...");
            Console.Write("Pick one: 1, 2 or 3: ");

            string userValue = Console.ReadLine();
            string message = "";


            if (userValue == "1") 
                 message = "You won a prize!";         
            else if (userValue == "2")        
                 message = "You won a boat!";          
            else if (userValue == "3")
                message = "You won a Jet!";
            else
            {
                 message = "Say what?\n";
                //message = message + "You lose.";
                message += "You lose fucker!";
            }

            Console.WriteLine(message);
            Console.ReadLine();
            Console.WriteLine("You've won : {0}",message);
            */

            /*
            Console.WriteLine("Get a surprise...");
            Console.Write("Pick one: 1, 2 or 3: ");

            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "boat" : "Balls!";

            Console.WriteLine("You pressed: {0}, You've won : {1}", userValue, message);
            Console.ReadLine();
            */


            #endregion

            #region Leson 3 Loops With Conditions

            for (int i = 0; i < 10; i++)

            {
                //Console.WriteLine(i);

                if (i == 7)
                {
                    Console.WriteLine("Got em!");
                    break;
                }

            }

            for (int xamlpa = 0; xamlpa < 10; xamlpa++)
            {
                Console.WriteLine(xamlpa);
            }

            Console.ReadLine();




            #endregion


            #region Lesson 4 Arrays

           


            #endregion



        }
    }
}
