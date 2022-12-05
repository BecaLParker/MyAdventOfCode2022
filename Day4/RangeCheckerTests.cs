using FluentAssertions;

namespace Day4;

public class RangeCheckerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void IsFullyContained_NonOverlappingPair_ShouldReturnFalse()
    {
        //Arrange
        var nonOverlappingPair = "2-4,6-8";
        var rangeChecker = new RangeChecker();

        //Act
        var result = rangeChecker.IsFullyContained(nonOverlappingPair);

        //Assert
        result.Should().Be(false);
    }
    
    [Test]
    public void IsFullyContained_PartiallyOverlappingPair_ShouldReturnFalse()
    {
        //Arrange
        var partiallyOverlappingPair = "5-7,7-9";
        var rangeChecker = new RangeChecker();

        //Act
        var result = rangeChecker.IsFullyContained(partiallyOverlappingPair);

        //Assert
        result.Should().Be(false);
    }
    
    [Test]
    public void IsFullyContained_FullyOverlappingPair_ShouldReturnTrue()
    {
        //Arrange
        var fullyOverlappingPair = "2-8,3-7";
        var rangeChecker = new RangeChecker();

        //Act
        var result = rangeChecker.IsFullyContained(fullyOverlappingPair);

        //Assert
        result.Should().Be(true);
    }

    [Test]
    public void CheckAllPairs_TestInput_ShouldReturn2()
    {
        //Arrange
        var testInput = @"2-4,6-8
        2-3,4-5
        5-7,7-9
        2-8,3-7
        6-6,4-6
        2-6,4-8";
        
        var rangeChecker = new RangeChecker();

        
        //Act
        var result = rangeChecker.CheckAllPairs(testInput, true);
        
        //Assert
        result.Should().Be(2);
    }

    [Test]
    public void Get3FirstStar()
    {
        //Arrange
        string day4InputPath = @"C:\AdventOfCode2022\Day4\Day4Input.txt";
        var input = File.ReadAllText(day4InputPath);
        var rangeChecker = new RangeChecker();
        
        //Act
        Console.WriteLine(rangeChecker.CheckAllPairs(input, true));
        
        //Assert
        
    }
    
    [Test]
    public void Get3SecondStar()
    {
        //Arrange
        string day4InputPath = @"C:\AdventOfCode2022\Day4\Day4Input.txt";
        var input = File.ReadAllText(day4InputPath);
        var rangeChecker = new RangeChecker();
        
        //Act
        Console.WriteLine(rangeChecker.CheckAllPairs(input, false));
        
        //Assert
        
    }


}