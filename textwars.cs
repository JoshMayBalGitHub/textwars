using System;
using System.Threading;
using System.IO;
namespace textwars
{
  class Program
  {
    static void Main(string[] args)
    {
      string config_all = "./config/config-all.txt";
      Console.Clear();
      Console.WriteLine("Type 'help' to disable / enable the help prompt!");
      cmderror:
      var helpmod = string.Join(" ", File.ReadAllLines(config_all)[1]);
      if (helpmod == "enable") {
        var text = File.ReadAllText("./config/help.txt");
        Console.WriteLine(text);
      } else if (helpmod == "disable") {
        goto conthelp;
      }
      conthelp:
      var name_cmd = string.Join(" ",File.ReadAllLines(config_all)[0]);
      Console.Write(name_cmd);
      Console.Write(" > ");
      var cmd = Console.ReadLine();
            switch (cmd) { case "textwars": {
                    Error:
                        Thread.Sleep(2000);
                        Console.WriteLine("Do you like school?");
                        Thread.Sleep(1500);
                        Console.WriteLine("Use Yes or No.");
                        var wololo = Console.ReadLine();
                        switch (wololo)
                        { case "Yes":
                                Console.WriteLine("Ok, Suuure....");
                                break;
                          case "yes":
                                Console.WriteLine("ok, suure..");
                                break;
                          case "No":
                                Console.WriteLine("Yeah, Mee Too....");
                                break;
                          case "no":
                                Console.WriteLine("yeah, me to..");
                                break;
                          default:
                                Console.WriteLine(wololo + ": Error, not a valid option...");
                                Thread.Sleep(1500);
                                goto Error; }
                    Error2:
                        Thread.Sleep(2000);
                        Console.WriteLine("Do you want to try again?");
                        Console.WriteLine("Answer Yes or No.");
                        var narwini = Console.ReadLine();
                        switch (narwini)
                        { case "Yes":
                                Console.WriteLine("Okk, That Is Good!");
                                goto Error;
                          case "yes": {
                                Console.WriteLine("ok, thats good.");
                                Console.WriteLine("in development.. sorry..");
                                Thread.Sleep(5000);
                                var lol1 = File.ReadAllText("./config/lol.txt");
                                Console.WriteLine(lol1);
                                Thread.Sleep(5000);
                                goto Error; }
                          case "No":
                                Console.WriteLine("OK Then! Exiting Out!");
                                goto cmderror;
                          case "no":
                                Console.WriteLine("NOOOOO! :( OK.....");
                                Thread.Sleep(5000);
                                Console.WriteLine("YOU SHALL BE BANISHED!");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                                break;
                          default:
                                Console.WriteLine("ERROR, try again.");
                                goto Error2; } 
                          break; }
                case "help": {
                    helpto:
                        Console.WriteLine("Type 'enable' and 'disable' exactly to enable / disable the help prompt!");
                        var helpmods = Console.ReadLine();
                        // Make sure to prevent accidental errors using:
                        if (helpmods == "enable") {
                          File.WriteAllLines(config_all, File.ReadAllLines(config_all).Select((line, index) => index == 1 ? "enable" : line));
                          goto cmderror;
                        } else if (helpmods == "disable") {
                          File.WriteAllLines(config_all, File.ReadAllLines(config_all).Select((line, index) => index == 1 ? "disable" : line));
                          goto cmderror;
                        } else {
                            Console.WriteLine(helpmods + ": not valid, try again!");
                            goto helpto; }} 
                case "exit":
                    Console.WriteLine("Ok.");
                    Environment.Exit(0);
                    break;
                case "change-name": {
                        Console.Write("Write your name here: ");
                        var cmd_name = Console.ReadLine();
                        if (cmd_name != null) {
                          File.WriteAllLines(config_all, File.ReadAllLines(config_all).Select((line, index) => index == 0 ? cmd_name : line));
                        } else {
                          Console.Write("Invalid.\n");}
                        goto cmderror;
                } case "game-config": {
                        Console.WriteLine("Available Games:");
                        Console.Write("1. textwars \n2. warstext");
                        var gam = Console.ReadLine();
                        break; 
                } case "clear":
                    Console.Clear();
                    goto cmderror;
                case "reset":
                    Console.WriteLine("Resetting...");
                    File.WriteAllLines(config_all, File.ReadAllLines(config_all).Select((line, index) => index == 1 ? "enable" : line));
                    File.WriteAllLines(config_all, File.ReadAllLines(config_all).Select((line, index) => index == 0 ? "lenovo-arch" : line));
                    Thread.Sleep(2000); Console.WriteLine("Done!");
                    goto cmderror;
                case "warstext": {
                        Thread.Sleep(2000);
                    goback:
                        Console.Clear();
                        Console.WriteLine("Write out the information to make funny requests.");
                        Console.WriteLine("Navigate with pressing <- and -> and by typing / pressing 'G', choose between the numbers by typing the number.");
                        Console.WriteLine("Press / Type 'Q' at any time to go back to terminal");
                        Console.WriteLine("1 - A little lesson in history");
                        var navkey = Console.ReadKey();
                        if (navkey.Key == ConsoleKey.RightArrow)
                        {
                        donothing:
                            Console.Clear();
                            Console.WriteLine("Navigate with pressing <- and -> and by typing / pressing 'G', choose between the numbers by typing the number.");
                            Console.WriteLine("Press / Type 'Q' at any time to go back to terminal");
                            Console.WriteLine("2 - Blackjack and Casinos");
                            navkey = Console.ReadKey();
                            if (navkey.Key == ConsoleKey.LeftArrow)
                            {
                                Console.Clear();
                                goto goback;
                            }
                            else if (navkey.Key == ConsoleKey.G)
                            {
                                Console.Clear();
                            navtext1:
                                Console.WriteLine("2 - Blackjack and Casinos");
                                var navtext = Console.ReadLine();
                                if (navtext == "2")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Write any name / names!");
                                    var name_warstext = Console.ReadLine();
                                    Console.WriteLine(name_warstext + " gonna go out with blackjack and casinos");
                                    Console.WriteLine("Press the 'Enter' key to go back to start");
                                    Console.ReadLine();
                                    goto donothing;
                                }
                                else if (navtext == "G" || navtext == "g")
                                {
                                    Console.Clear();
                                    goto donothing;
                                }
                                else if (navtext == "Q" || navtext == "q")
                                {
                                    Console.Clear();
                                    goto cmderror;
                                }
                                else
                                {
                                    Console.WriteLine("Try again. Invalid number: " + navtext);
                                    goto navtext1;
                                }
                            }
                            else if (navkey.Key == ConsoleKey.Q)
                            {
                                Console.Clear();
                                goto cmderror;
                            }
                            else
                            {
                                Console.Clear();
                                goto donothing;
                            }
                        }
                        else if (navkey.Key == ConsoleKey.G) {
                            Console.Clear();
                          navtext1:
                            Console.WriteLine("1 - A little lesson in history");
                            var navtext = Console.ReadLine();
                            if (navtext == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("Write any name / names!");
                                var name_warstext = Console.ReadLine();
                                Console.WriteLine(name_warstext + " the number ONE!");
                                Console.WriteLine("Press the 'Enter' key to go back to start");
                                Console.ReadLine();
                                goto goback;
                            }
                            else if (navtext == "G" || navtext == "g")
                            {
                                Console.Clear();
                                goto goback;
                            }
                            else if (navtext == "Q" || navtext == "q")
                            {
                                Console.Clear();
                                goto cmderror;
                            }
                            else
                            {
                                Console.WriteLine("Try again. Invalid number: " + navtext);
                                goto navtext1;
                            }
                        }
                        else if (navkey.Key == ConsoleKey.Q)
                        {
                            Console.Clear();
                            goto cmderror;
                        }
                        else
                        {
                            Console.Clear();
                            goto goback;
                        }
                    }
                default:
                    Console.WriteLine("twsh: Command not found. Please try again: " + cmd);
                    Thread.Sleep(2000);
                    goto cmderror;
      }
    }
  }
}