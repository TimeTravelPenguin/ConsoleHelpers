#region Title Header

// Name: Phillip Smith
// 
// Solution: ConsoleHelpers
// Project: ConsoleHelpers.Tests
// File Name: ConsoleInputTests.cs
// 
// Current Data:
// 2021-04-21 10:26 PM
// 
// Creation Date:
// 2021-04-21 5:29 PM

#endregion

using FluentAssertions;
using Xunit;

namespace ConsoleHelpers.Tests
{
  public class ConsoleInputTests
  {
    public class YesNoInputTests
    {
      [Fact]
      public void ReturnsInput()
      {
        var fake = new FakeConsole();

        var input = fake.AcceptYesNo("UnitTest");

        input.Should()
          .BeOfType<Input>();
      }

      [Fact]
      public void ReturnsNo()
      {
        var fake = new FakeConsole(new[] {'n'});

        var input = fake.AcceptYesNo("UnitTest");

        input.Should()
          .Be(Input.No);
      }

      [Fact]
      public void ReturnsYes()
      {
        var fake = new FakeConsole(new[] {'y'});

        var input = fake.AcceptYesNo("UnitTest");

        input.Should()
          .Be(Input.Yes);
      }
    }

    public class IntInputTests
    {
      [Fact]
      public void ReturnsInput()
      {
        var fake = new FakeConsole();

        var input = fake.AcceptInt("UnitTest");

        input.Should()
          .BeOfType(typeof(int));
      }
    }
  }
}