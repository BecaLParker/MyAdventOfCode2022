using FluentAssertions;

namespace Day1;

public class EngineTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void MostCalories_OneElfWithOneCalorie_ShouldReturnOne()
    {
        //Arrange
        var testElf = new Elf(new[]{1});
        var elves = new List<Elf>() { testElf };
        var engine = new Engine();

        //Act
        var result = engine.MostCalories(elves);

        //Assert
        result.Should().Be(1);
    }
}