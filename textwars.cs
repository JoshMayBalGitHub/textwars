using System;

namespace textwars
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      cmderror:
      Console.WriteLine("Type 'help' to disable / enable the help prompt!");
      var helpmod = string.Join(" ", File.ReadAllText("./config/helpmod.txt"));
      if (helpmod == "enable") {
        var text = File.ReadAllText("./config/help.txt");
        Console.WriteLine(text);
      } else if (helpmod == "disable") {
        goto conthelp;
      }
      conthelp:
      var name_cmd = string.Join(" ", File.ReadAllText("./config/cmd_name.txt"));
      Console.Write(name_cmd);
      Console.Write(" > ");
      var cmd = Console.ReadLine();
      if (cmd == "textwars") 
      {
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
        Console.WriteLine(wololo + ": Error, not a valid option...");
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
      else if (cmd == "help") 
      {
        helpto:
        Console.WriteLine("Type 'enable' and 'disable' exactly to enable / disable the help prompt!");
        var helpmods = Console.ReadLine();
        // Make sure to prevent accidental errors using:
        if (helpmods == "enable") {
          File.WriteAllText("./config/helpmod.txt", "enable");
          goto cmderror;
        } else if (helpmods == "disable") {
          File.WriteAllText("./config/helpmod.txt", "disable");
          goto cmderror;
        } else {
          Console.WriteLine(helpmods + ": not valid, try again!");
          goto helpto;
        }
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
        File.WriteAllText("./config/cmd_name.txt", cmd_name);
        goto cmderror;
      } 
      else if (cmd == "clear") {
        Console.Clear();
        goto cmderror;
      }
      else if (cmd == "reset") {
        Console.WriteLine("Resetting...");
        File.WriteAllText("./config/cmd_name.txt", "lenovo-arch");
        File.WriteAllText("./config/helpmod.txt", "enable");
        Thread.Sleep(2000); Console.WriteLine("Done!");
        goto cmderror;
      }
      else if (cmd == "warstext") {
        Thread.Sleep(2000);
        goback:
        Console.Clear();
        Console.WriteLine("Write out the information to make funny requests.");
        Console.WriteLine("Choose between the numbers, get more with pressing <- and ->");
        Console.WriteLine("Press 'Q' at any time to go back to terminal");
        Console.WriteLine("1 - A little lesson in history");
        var navkey = Console.ReadKey();
        if (navkey.Key == ConsoleKey.RightArrow) {
          donothing:
          Console.Clear();
          Console.WriteLine("2 - Blackjack and Casinos");
          navkey = Console.ReadKey();
          if (navkey.Key == ConsoleKey.LeftArrow) {
            goto goback;
          } else if (navkey.Key == ConsoleKey.D2) {
          Console.Clear();
          Console.WriteLine("Write any name / names!");
          var name_warstext = Console.ReadLine();
          Console.WriteLine(name_warstext + " gonna go out with blackjack and casinos");
          Console.WriteLine("Press the 'Enter' key to go back to start");
          Console.ReadLine();
          goto goback;
           }
           else if (navkey.Key == ConsoleKey.Q) {
            Console.Clear();
            goto cmderror;
          }else {goto donothing;}
        } else if (navkey.Key == ConsoleKey.D1) {
          Console.Clear();
          Console.WriteLine("Write any name / names!");
          var name_warstext = Console.ReadLine();
          Console.WriteLine(name_warstext + " the number ONE!");
          Console.WriteLine("Press the 'Enter' key to go back to start");
          Console.ReadLine();
          goto goback;
        }
        else if (navkey.Key == ConsoleKey.Q) {
            Console.Clear();            
            goto cmderror;
          } else {goto goback;}
      }
      else {
        Console.WriteLine("twsh: Command not found. Please try again: " + cmd);
        goto cmderror;
      }
    }
  }
}