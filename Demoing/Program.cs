#region Title Header

// Name: Phillip Smith
// 
// Solution: ConsoleHelpers
// Project: Demoing
// File Name: Program.cs
// 
// Current Data:
// 2021-04-21 10:33 PM
// 
// Creation Date:
// 2021-04-21 12:49 PM

#endregion

using System;
using ConsoleHelpers;

namespace Demoing
{
  public static class Program
  {
    private static readonly ConsoleMediator ConsoleMediator = new();

    public static void Main(string[] args)
    {
      Console.WriteLine();
      Console.WriteLine("This is a simple application to demonstrate console helper methods");

      Console.CursorLeft = 5;
      var input = ConsoleMediator.AcceptYesNo("Please select from the following options", "Invalid input...");

      Console.WriteLine($"Thank you. You have chosen the option: {input}");
      Console.ReadKey(true);
    }
  }
}