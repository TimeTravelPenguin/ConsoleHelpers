using System;
using Helpers;

namespace ConsoleHelpers.Tests
{
  internal class FakeConsole : IConsole
  {
    private readonly char[] _inputArray;

    public FakeConsole()
    {
      _inputArray = Constants.AlphaNumeric
        .ToCharArray();
    }

    public FakeConsole(char[] inputArray)
    {
      _inputArray = inputArray;
    }

    public ConsoleKeyInfo ReadKey()
    {
      throw new NotImplementedException();
    }

    public ConsoleKeyInfo ReadKey(bool intercept)
    {
      throw new NotImplementedException();
    }

    public string ReadLine()
    {
      return _inputArray.RandomIn().ToString();
    }

    public void Write(string message)
    {
    }

    public void WriteLine()
    {
    }

    public void WriteLine(string message)
    {
    }

    public int CursorLeft { get; set; }
    public int CursorTop { get; set; }
    public int WindowWidth { get; set; }
    public int WindowHeight { get; set; }
    public ConsoleColor ForegroundColor { get; set; }
    public ConsoleColor BackgroundColor { get; set; }

    public void SetCursorPosition(int left, int top)
    {
    }

    public (int left, int top) GetCursorPosition()
    {
      return (0, 0);
    }
  }
}
