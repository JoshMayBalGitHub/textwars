using System;

namespace ConsoleApp2
{
    class Program
    {
         static void Main(string[] args) {
             label:
            Console.WriteLine("Do you like school?");
            Console.WriteLine("Also, use Yes or No, pls");
            string name = Console.ReadLine();
            if (name == "Yes")
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
                Console.WriteLine("Ok, Sure Bud.");
            }
            else if (name == "No") {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
                Console.WriteLine("Yeah, me too.");
            }
            else if (name == "no")
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
               Console.WriteLine("Yeah, me too.");
            }
            else if (name == "yes")
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
                Console.WriteLine("Ok, Sure Bud.");
            }
            else
            {
                Console.WriteLine("Pls. Yes or No, I beg you");
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
                goto label;
            }
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));

            Console.WriteLine("Do you want to try again?");
            Console.WriteLine("Pls, Answer Yes or No.");
            string answer = Console.ReadLine();
            if (answer == "Yes")
            {
                Console.WriteLine("Ok.");
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
                goto label;
            }
            else if (answer == "No") {
                Console.WriteLine("Ok, then..");
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            }
            else if (answer == "no")
            {
               Console.WriteLine("Ok, then..");
               System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
               
            }
            else if (answer == "yes")
            {
                Console.WriteLine("Ok.");
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
                goto label;
            }
            else
            {
                Console.WriteLine("Pls. I beg you");
                goto label;
            }

        
        }
    }
}