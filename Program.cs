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
        var text = System.IO.File.ReadAllText("./config/help.txt");
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
      Console.WriteLine("In development, sorry about that!");
      Thread.Sleep(5000);
      goto cmderror;
    }
  }
}
