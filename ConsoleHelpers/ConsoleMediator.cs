#region Title Header

// Name: Phillip Smith
// 
// Solution: ConsoleHelpers
// Project: ConsoleHelpers
// File Name: ConsoleMediator.cs
// 
// Current Data:
// 2021-04-21 5:51 PM
// 
// Creation Date:
// 2021-04-21 5:51 PM

#endregion

using System;

namespace ConsoleHelpers
{
  public class ConsoleMediator : IConsole
  {
    public ConsoleKeyInfo ReadKey()
    {
      return Console.ReadKey();
    }

    public ConsoleKeyInfo ReadKey(bool intercept)
    {
      return Console.ReadKey(intercept);
    }

    public string ReadLine()
    {
      return Console.ReadLine();
    }

    public void Write(string message)
    {
      Console.Write(message);
    }

    public void WriteLine()
    {
      Console.WriteLine();
    }

    public void WriteLine(string message)
    {
      Console.WriteLine(message);
    }

    public int CursorLeft
    {
      get => Console.CursorLeft;
      set => Console.CursorLeft = value;
    }

    public int CursorTop
    {
      get => Console.CursorTop;
      set => Console.CursorTop = value;
    }

    public int WindowWidth
    {
      get => Console.WindowWidth;
      set => Console.WindowWidth = value;
    }

    public int WindowHeight
    {
      get => Console.WindowHeight;
      set => Console.WindowHeight = value;
    }

    public ConsoleColor ForegroundColor
    {
      get => Console.ForegroundColor;
      set => Console.ForegroundColor = value;
    }

    public ConsoleColor BackgroundColor
    {
      get => Console.BackgroundColor;
      set => Console.BackgroundColor = value;
    }

    public void SetCursorPosition(int left, int top)
    {
      Console.SetCursorPosition(left, top);
    }

    public (int left, int top) GetCursorPosition()
    {
      return Console.GetCursorPosition();
    }
  }
}