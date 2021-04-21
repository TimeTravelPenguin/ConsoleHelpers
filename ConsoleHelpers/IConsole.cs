#region Title Header

// Name: Phillip Smith
// 
// Solution: ConsoleHelpers
// Project: ConsoleHelpers
// File Name: IConsole.cs
// 
// Current Data:
// 2021-04-21 9:25 PM
// 
// Creation Date:
// 2021-04-21 9:25 PM

#endregion

using System;

namespace ConsoleHelpers
{
  public interface IConsole : IReaderWriter
  {
    int CursorLeft { get; set; }
    int CursorTop { get; set; }
    int WindowWidth { get; set; }
    int WindowHeight { get; set; }
    ConsoleColor ForegroundColor { get; set; }
    ConsoleColor BackgroundColor { get; set; }
    void SetCursorPosition(int left, int top);
    (int left, int top) GetCursorPosition();
  }
}