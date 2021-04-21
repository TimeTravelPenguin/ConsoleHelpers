using System;

namespace ConsoleHelpers
{
  public static class ConsoleInput
  {
    public static Input AcceptYesNo(this IConsole console, string question, string onErrorMessage = null)
    {
      console.CursorTop += 1;
      var (curLeft, curTop) = console.GetCursorPosition();

      string input;

      while (true)
      {
        console.SetCursorPosition(curLeft, curTop);
        console.ClearLine();
        console.CursorLeft = curLeft; // preserve CursorLeft offset

        console.WriteColor(question, ConsoleColor.DarkYellow);
        console.WriteColor(" [y/n]: ", ConsoleColor.Blue);

        input = console.ReadLine()?.Trim().ToLowerInvariant();

        if (input == "y" || input == "n")
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

      return input switch
      {
        "y" => Input.Yes,
        "n" => Input.No,
        _ => throw new InvalidOperationException()
      };
    }
}
}
