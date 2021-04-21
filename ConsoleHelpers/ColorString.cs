using System;

namespace ConsoleHelpers
{
  public class ColorString
  {
    public string Content { get; set; }
    public ConsoleColor ForeColor { get; set; }
    public ConsoleColor BackColor { get; set; }

    public ColorString(string content, ConsoleColor foreColor, ConsoleColor backColor = ConsoleColor.Black)
    {
      Content = content;
      ForeColor = foreColor;
      BackColor = backColor;
    }

    public override string ToString()
    {
      return Content;
    }

    public static implicit operator ColorString(string value)
    {
      return new(value, ConsoleColor.White);
    }

    public static implicit operator string(ColorString value)
    {
      return value.Content;
    }
  }
}
