#region Title Header

// Name: Phillip Smith
// 
// Solution: ConsoleHelpers
// Project: Demoing
// File Name: IntInputDemo.cs
// 
// Current Data:
// 2021-04-22 7:15 PM
// 
// Creation Date:
// 2021-04-22 7:15 PM

#endregion

using ConsoleHelpers;

namespace Demoing.Demos
{
  [Demo]
  public class IntInputDemo : IDemo
  {
    public void Run(IConsole console)
    {
      console.WriteLine();
      console.WriteLine("This is a simple application to demonstrate console helper methods");

      console.CursorLeft = 5;
      var input = console.AcceptInt("Please input an integer", "Invalid input...");
      console.WriteLine($"Thank you. You have provided the value: {input}");
      console.WriteLine($"This value is of type: {input.GetType()}");
    }
  }
}