using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList {

  public class Program
  {
    public static void Main()
    {
      string line;
      
      for (int index = 0; index < 1; )
      {
        Console.WriteLine("Would you like to add an item to your list?(add/view/exit)");
        
        line = Console.ReadLine();
        if (line == "exit")
        {
          index = 1;
        }
        else if (line == "add")
        {
          Console.WriteLine("Please enter a description.");
          line = Console.ReadLine();
          new Item(line);
        }
        else if (line == "view")
        {
          List<Item> results = Item.GetAll();
          foreach (Item element in results)
          {
            Console.WriteLine(element.Description);
          }
        }
        else
        {
          Console.WriteLine("Error command not recognized.");
        }
      }
    }
  }
}

