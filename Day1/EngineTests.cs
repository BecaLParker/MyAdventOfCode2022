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
        var testElf = new Elf(new List<int>() {1});
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
    [Test]
    public void MostCalories_ElfButNoCalories_ShouldReturnZero()
    {
        //Arrange
        var testElf = new Elf(new List<int>());
        var elves = new List<Elf>() { testElf };
        var engine = new Engine();

        //Act
        var result = engine.MostCalories(elves);

        //Assert
        result.Should().Be(0);
    }

    [Test]
    public void TopThree_OnlyThreeElves_ShouldReturnTotalOfThoseElves()
    {
        //Arrange
        var testElf1 = new Elf(new List<int>(){1});
        var testElf2 = new Elf(new List<int>(){2});
        var testElf3 = new Elf(new List<int>(){3});
        var elves = new List<Elf>() { testElf1, testElf2, testElf3 };
        var engine = new Engine();

        //Act
        var result = engine.CaloriesFromTopThree(elves);

        //Assert
        result.Should().Be(6);
    }
}