using System.Xml.XPath;
using FluentAssertions;

namespace Day1;

[TestFixture]
public class ElfFactoryTests
{
    
    [Test]
    public void Create_FromDay1Input_ShouldReturnAppropriateSetOfElves()
    {
        //Arrange
        var factory = new ElfFactory();
        var expectedFirstElf = new Elf(new List<int>(){2936, 2154, 1578, 4820, 5674, 5582, 2392, 6148, 1276, 1783, 2572, 5067, 3526});
        var expectedLastElf = new Elf(new List<int>(){9821, 7551, 1459, 6217, 10094, 1445, 9978});
        
        //Act
        string day1InputPath = @"C:\AdventOfCode2022\Day1\input.txt";
        var result = factory.Create(day1InputPath);
        
        //Assert
        result.Should().NotBeEmpty();
        result.First().TotalCalories().Should().Be(expectedFirstElf.TotalCalories());
        result.Last().TotalCalories().Should().Be(expectedLastElf.TotalCalories());
    }

    [Test]
    public void HackToFirstStar()
    {
        //Arrange
        var factory = new ElfFactory();
        string day1InputPath = @"C:\AdventOfCode2022\Day1\input.txt";
        var elves = factory.Create(day1InputPath);
        var engine = new Engine();
        
        //Act
        var answer = engine.MostCalories(elves);
        
        //Assert
        answer.Should().Be(74198);
    }
    
    [Test]
    public void HackToSecondStar()
    {
        //Arrange
        var factory = new ElfFactory();
        string day1InputPath = @"C:\AdventOfCode2022\Day1\input.txt";
        var elves = factory.Create(day1InputPath);
        var engine = new Engine();
        
        //Act
        var answer = engine.CaloriesFromTopThree(elves);
        
        //Assert
        answer.Should().Be(209914);
    }

}