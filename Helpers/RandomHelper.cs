using System.Collections.Generic;
using System.Linq;

namespace Helpers
{
  public static class RandomHelper
  {
    public static void Shuffle<T>(this IList<T> list)
    {
      var n = list.Count;

      while (n > 1)
      {
        n--;

        var k = ThreadSafeRandom.Random.Next(n + 1);

        var value = list[k];
        list[k] = list[n];
        list[n] = value;
      }
    }

    public static T RandomIn<T>(this IList<T> list)
    {
      var idx = ThreadSafeRandom.Random.Next(list.Count);
      return list[idx];
    }

    public static string RandomString(int length)
    {
      var characters = Enumerable.Range(0x21, 0x5D)
        .Select(x => (char) x)
        .ToList();

      var randString = string.Empty;
      for (var i = 0; i < length; i++)
      {
        randString += characters.RandomIn();
      }

      return randString;
    }
  }
}

