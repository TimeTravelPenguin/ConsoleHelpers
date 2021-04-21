using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Extensions
{
  public static class AssemblyExtensions
  {
    public static IEnumerable<Type> GetTypesWithHelpAttribute<T>(this Assembly assembly)
    {
      return assembly.GetTypes()
        .Where(type => type.GetCustomAttributes(typeof(T), true).Length > 0);
    }
  }
}
