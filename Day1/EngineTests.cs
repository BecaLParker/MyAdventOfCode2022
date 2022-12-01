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

    [Test]
    public void MostCalories_NoElves_ShouldReturnZero()
    {
        //Arrange
        var noElves = new List<Elf>();
        var engine = new Engine();

        //Act
        var result = engine.MostCalories(noElves);

        //Assert
        result.Should().Be(0);
    }
}