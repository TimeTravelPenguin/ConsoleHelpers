#region Title Header

// Name: Phillip Smith
// 
// Solution: ConsoleHelpers
// Project: Demoing
// File Name: Program.cs
// 
// Current Data:
// 2021-04-21 10:33 PM
// 
// Creation Date:
// 2021-04-21 12:49 PM

#endregion

using System;
using System.Linq;
using System.Reflection;
using ConsoleHelpers;
using Extensions;
using Helpers;

namespace Demoing
{
  public static class Program
  {
    private static readonly GenericFactory<IDemo> DemoFactory;
    private static readonly ConsoleMediator ConsoleMediator = new();

    static Program()
    {
      DemoFactory = new GenericFactory<IDemo>(SetupFactory);
    }

    public static void Main()
    {
      DemoFactory.Construct(nameof(YesNoDemo))
        .Run(ConsoleMediator);

      Console.ReadKey(true);
    }

    private static void SetupFactory(GenericFactory<IDemo> fact)
    {
      var demos = Assembly.GetExecutingAssembly()
        .GetTypesWithHelpAttribute<DemoAttribute>()
        .Where(t => t.GetInterfaces().Contains(typeof(IDemo)))
        .ToList();

      foreach (var demo in demos)
      {
        fact.Register(demo.Name, () => Activator.CreateInstance(demo) as IDemo);
      }
    }
  }
}