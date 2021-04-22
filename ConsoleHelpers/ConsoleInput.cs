using System;
using System.Collections.Generic;

namespace ConsoleHelpers
{
  public static class ConsoleInput
  {
    public static Input AcceptYesNo(this IConsole console, string question, string onErrorMessage = null)
    {
      console.CursorTop += 1;
      var (curLeft, curTop) = console.GetCursorPosition();

      var yesNoQuestion = new[]
      {
        new ColorString(question, ConsoleColor.DarkYellow),
        new ColorString(" [y/n]: ", ConsoleColor.Blue)
      };

      var input = RequestInput(console, yesNoQuestion, new[] {"y", "n"}, onErrorMessage, curLeft, curTop);

      return input switch
      {
        "y" => Input.Yes,
        "n" => Input.No,
        _ => throw new InvalidOperationException()
      };
    }

    private static string RequestInput(IConsole console, ICollection<ColorString> question,
      ICollection<string> inputOptions, string onErrorMessage,
      int curLeft, int curTop)
    {
      string input;
      while (true)
      {
        WriteInputQuestion(console, question, curLeft, curTop);

        input = console.ReadLine()?.Trim().ToLowerInvariant();

        if (inputOptions.Contains(input))
        {
          console.ClearLine();
          console.CursorTop += 1;


          break;
        }

        if (onErrorMessage is not null)
        {
          console.CursorLeft = curLeft;
          console.WriteLineColor(onErrorMessage + Environment.NewLine, ConsoleColor.DarkRed);
          console.SetCursorPosition(curLeft, curTop);
          curTop = console.CursorTop;
        }
      }

      return input;
    }

    private static void WriteInputQuestion(IConsole console, IEnumerable<ColorString> question, int curLeft, int curTop)
    {
      console.SetCursorPosition(curLeft, curTop);
      console.ClearLine();
      console.CursorLeft = curLeft; // preserve CursorLeft offset

      console.WriteColor(question);
    }
  }
}
