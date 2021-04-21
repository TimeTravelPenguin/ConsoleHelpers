using System;

namespace ConsoleHelpers
{
  public interface IReaderWriter
  {
    ConsoleKeyInfo ReadKey();
    ConsoleKeyInfo ReadKey(bool intercept);

    string ReadLine();

    void Write(string message);

    void WriteLine();
    void WriteLine(string message);
  }
}