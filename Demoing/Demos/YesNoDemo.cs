#region Title Header

// Name: Phillip Smith
// 
// Solution: ConsoleHelpers
// Project: Demoing
// File Name: YesNoDemo.cs
// 
// Current Data:
// 2021-04-22 9:33 AM
// 
// Creation Date:
// 2021-04-22 9:33 AM

#endregion

using ConsoleHelpers;

namespace Demoing.Demos
{
  [Demo]
  public class YesNoDemo : IDemo
  {
    public void Run(IConsole console)
    {
      console.WriteLine();
      console.WriteLine("This is a simple application to demonstrate console helper methods");

      console.CursorLeft = 5;
      var input = console.AcceptYesNo("Please select from the following options", "Invalid input...");
      console.WriteLine($"Thank you. You have chosen the option: {input}");
    }
  }
}