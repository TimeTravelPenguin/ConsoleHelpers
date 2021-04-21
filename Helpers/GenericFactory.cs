using System;
using System.Collections.Generic;

namespace Helpers
{
  public class GenericFactory<T>
  {
    private readonly IDictionary<string, Func<T>> _registry = new Dictionary<string, Func<T>>();

    public GenericFactory(Action<GenericFactory<T>> initialisation)
    {
      initialisation.Invoke(this);
    }

    public void Register(string key, Func<T> value)
    {
      if (_registry.ContainsKey(key))
      {
        throw new InvalidOperationException();
      }

      _registry.Add(key, value);
    }

    public T Construct(string key)
    {
      if (_registry.TryGetValue(key, out var value))
      {
        return value.Invoke();
      }

      throw new InvalidOperationException();
    }
  }
}
