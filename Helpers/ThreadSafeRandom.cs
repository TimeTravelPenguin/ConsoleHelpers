#region Title Header

// Name: Phillip Smith
// 
// Solution: ConsoleHelpers
// Project: Helpers
// File Name: ThreadSafeRandom.cs
// 
// Current Data:
// 2021-04-21 6:04 PM
// 
// Creation Date:
// 2021-04-21 6:04 PM

#endregion

using System;
using System.Threading;

namespace Helpers
{
  public static class ThreadSafeRandom
  {
    public static Random Random =>
      _local ??= new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId));

    [ThreadStatic] private static Random _local;
  }
}