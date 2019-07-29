using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ToDoList
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}




// using System;
// using System.Collections.Generic;
// using ToDoList.Models;

// class Program
// {
//     private static string userInput = "";

//     private static void PromptUser()
//     {
//         Console.Write("Would you like to add an item to your list or view your list? (Add/View): ");
//         userInput = Console.ReadLine();

//         if (userInput == "Add" || userInput == "add" || userInput == "a")
//         {
//             Console.Write("Your new to-do item: ");
//             userInput = Console.ReadLine();

//             Item newItem = new Item(userInput);
//             Console.WriteLine($"\"{userInput}\" has been added to your list.");
//             PromptUser();
//         }
//         else if (userInput == "View" || userInput == "view" || userInput == "v")
//         {
//             List<Item> itemList = Item.GetAll();
//             if (itemList.Count < 1)
//             {
//                 Console.WriteLine("There are no items on your list.");
//             }
//             else
//             {
//                 for (int i = 0; i < itemList.Count; i++)
//                 {
//                     Console.WriteLine($"{i + 1}. {itemList[i].Description}");
//                 }
//             }
//             PromptUser();
//         }
//         else
//         {
//             Console.WriteLine("Please enter a valid input.");
//             PromptUser();
//         }
//     }

//     private static void Main()
//     {
//         Console.WriteLine("Welcome to the To Do List!");
//         PromptUser();
//     }
// }
