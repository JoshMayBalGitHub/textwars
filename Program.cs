using System;

namespace textwars
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Type 'help' for the available commands!");
      cmderror:
      var name_cmd = string.Join(" ", File.ReadAllLines("./config/cmd_name.txt"));
      Console.Write(name_cmd);
      Console.Write(" > ");
      var cmd = Console.ReadLine();
      if (cmd == "textwars") 
      {
        goto Error;
      } 
      else if (cmd == "help") 
      {
        var text = File.ReadAllText("./config/help.txt");
        Console.WriteLine(text);
        goto cmderror;
      }
      else if (cmd == "exit") 
      {
        Console.WriteLine("Ok.");
        Environment.Exit(0);
      }
      else if (cmd == "change-name") 
      {
        Console.Write("Write your name here: ");
        var cmd_name = Console.ReadLine();
        File.WriteAllTextAsync("./config/cmd_name.txt", cmd_name);
        goto cmderror;
      } 
      else if (cmd == "clear") {
        Console.Clear();
        goto cmderror;
      }
      else {
        Console.WriteLine(cmd + ": Command not found. Please try again");
        goto cmderror;
      }

      Error:
      Thread.Sleep(2000);
      Console.WriteLine("Do you like school?");
      Thread.Sleep(1500);
      Console.WriteLine("Use Yes or No.");
      var wololo = Console.ReadLine();

      if (wololo == "Yes")
      {
        Console.WriteLine("Ok, Suuure....");
      }
      else if (wololo == "yes")
      {
        Console.WriteLine("ok, suure..");
      }
      else if (wololo == "No")
      {
        Console.WriteLine("Yeah, Mee Too....");
      }
      else if (wololo == "no")
      {
        Console.WriteLine("yeah, me to..");
      }
      else
      {
        Console.WriteLine(wololo + ": Error, not a valid option");
        Thread.Sleep(1500);
        goto Error;
      }

      Error2:
      Thread.Sleep(2000);
      Console.WriteLine("Do you want to try again?");
      Console.WriteLine("Answer Yes or No.");
      var narwini = Console.ReadLine();
      if (narwini == "Yes")
      {
        Console.WriteLine("Okk, That Is Good!");
        goto Error;
      }
      else if (narwini == "yes")
      {
        Console.WriteLine("ok, thats good.");
        Console.WriteLine("in development.. sorry..");
        Thread.Sleep(5000);
        var lol1 = File.ReadAllText("./config/lol.txt");
        Console.WriteLine(lol1);
        Thread.Sleep(5000);
        goto Error;
      }
      else if (narwini == "No")
      {
        Console.WriteLine("OK Then! Exiting Out!");
        goto cmderror;
      }
      else if (narwini == "no")
      {
        Console.WriteLine("NOOOOO! :( OK.....");
        Thread.Sleep(5000);
        Console.WriteLine("YOU SHALL BE BANISHED!");
        Thread.Sleep(5000);
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
