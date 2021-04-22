#region Title Header

// Name: Phillip Smith
// 
// Solution: ConsoleHelpers
// Project: ConsoleHelpers
// File Name: ConsoleWrite.cs
// 
// Current Data:
// 2021-04-21 1:32 PM
// 
// Creation Date:
// 2021-04-21 1:10 PM

#endregion

using System;
using System.Collections.Generic;

namespace ConsoleHelpers
{
  public static class ConsoleWrite
  {
    public static void ClearLine(this IConsole rw)
    {
      var top = rw.CursorTop;
      rw.Write(new string(' ', rw.WindowWidth - rw.CursorLeft));
      rw.SetCursorPosition(0, top);
    }

    public static void WriteLineColor(this IConsole rw, ColorString message)
    {
      WriteLineColor(rw, message.Content, message.ForeColor, message.BackColor);
    }

    public static void WriteLineColor(this IConsole rw, IEnumerable<ColorString> messages)
    {
      rw.WriteColor(messages);
      rw.WriteLine();
    }

    public static void WriteLineColor(this IConsole rw, string message, ConsoleColor foreground)
    {
      WriteLineColor(rw, message, foreground, rw.BackgroundColor);
    }

    public static void WriteLineColor(this IConsole rw, string message, ConsoleColor foreground,
      ConsoleColor background)
    {
      WriteColor(rw, message, foreground, background);
      rw.WriteLine();
    }

    public static void WriteColor(this IConsole rw, ColorString message)
    {
      WriteColor(rw, message.Content, message.ForeColor, message.BackColor);
    }

    public static void WriteColor(this IConsole rw, IEnumerable<ColorString> messages)
    {
      foreach (var message in messages)
      {
        rw.WriteColor(message);
      }
    }

    public static void WriteColor(this IConsole rw, string message, ConsoleColor foreground)
    {
      WriteColor(rw, message, foreground, Console.BackgroundColor);
    }

    public static void WriteColor(this IConsole rw, string message, ConsoleColor foreground,
      ConsoleColor background)
    {
      var fore = Console.ForegroundColor;
      var back = Console.BackgroundColor;

      rw.ForegroundColor = foreground;
      rw.BackgroundColor = background;

      rw.Write(message);

      rw.ForegroundColor = fore;
      rw.BackgroundColor = back;
    }
  }
}