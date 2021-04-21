#region Title Header

// Name: Phillip Smith
// 
// Solution: ConsoleHelpers
// Project: Demoing
// File Name: DemoAttribute.cs
// 
// Current Data:
// 2021-04-22 9:13 AM
// 
// Creation Date:
// 2021-04-22 9:13 AM

#endregion

using System;

namespace Demoing
{
  [AttributeUsage(AttributeTargets.Class)]
  public class DemoAttribute : Attribute
  {
  }
}