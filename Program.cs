using System;

namespace textwars
{
  class Program
  {
    static void Main(string[] args)
    {
      Error:
      Console.WriteLine("Do you like school?");
      Console.WriteLine("Also, use Yes or No, pls");
      var wololo = Console.ReadLine();

      if (wololo == "Yes")
      {
        Console.WriteLine("Ok, Sure Bud.");
      }
      else if (wololo == "yes")
      {
        Console.WriteLine("Ok, Sure Bud.");
      }
      else if (wololo == "No")
      {
        Console.WriteLine("Yeah, me too.");
      }
      else if (wololo == "no")
      {
        Console.WriteLine("Yeah, me too.");
      }
      else
      {
        Console.WriteLine("ERROR, try again.");
        goto Error;
      }
      Error2:
      Console.WriteLine("Do you want to try again?");
      Console.WriteLine("Pls, Answer Yes or No.");
      var narwini = Console.ReadLine();
      if (narwini == "Yes")
      {
        Console.WriteLine("Ok.");
        goto Error;
      }
      else if (narwini == "yes")
      {
        Console.WriteLine("Ok.");
        goto Error;
      }
      else if (narwini == "No")
      {
        Console.WriteLine("Ok.");
        Environment.Exit(0);
      }
      else if (narwini == "no")
      {
        Console.WriteLine("Ok.");
        Environment.Exit(0);
      }
      else
      {
        Console.WriteLine("ERROR, try again.");
        goto Error2;
      }
      
    }
  }
}
/*
try
      {
        wololo = Console.ReadLine();
      }
      catch (Exception)
      {
        Console.WriteLine("ERROR, try again.");
        goto Error;
      }
      switch(wololo)
      { */
        