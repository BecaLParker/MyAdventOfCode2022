using FluentAssertions;

namespace Day2;

public class ScorerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CalculateRoundScore_BvsX_ShouldReturn1()
    {
        //Arrange
        var roundInput = "B X";
        var calculator = new Scorer();

        //Act
        var result = calculator.CalculateRoundScore(roundInput, true);
        
        //Assert
        result.Should().Be(1);
    }
    
    [Test]
    public void CalculateRoundScore_CvsZ_ShouldReturn6()
    {
        //Arrange
        var roundInput = "C Z";
        var calculator = new Scorer();

        //Act
        var result = calculator.CalculateRoundScore(roundInput, true);
        
        //Assert
        result.Should().Be(6);
    }
    
    [Test]
    public void CalculateRoundScore_AvsY_ShouldReturn8()
    {
        //Arrange
        var roundInput = "A Y";
        var calculator = new Scorer();

        //Act
        var result = calculator.CalculateRoundScore(roundInput, true);
        
        //Assert
        result.Should().Be(8);
    }

    [Test]
    public void CalculateGameScore_Rounds1to3_ShouldReturn15()
    {
        //Arrange
        var gameInput = new List<string>()
        {
            "B X", "Z C", "A Y"
        };
        var calculator = new Scorer();

        //Act
        var result = calculator.CalculateGameScore(gameInput, true);
        
        //Assert
        result.Should().Be(15);
    }


    [Test]
    public void HackToDay2PartTwo()
    {
        //Arrange
        string day2InputPath = @"C:\AdventOfCode2022\Day2\Day2Input.txt";
        var lines = File.ReadAllText(day2InputPath).Split(Environment.NewLine);
        var calculator = new Scorer();
        
        //Act
        var answer = calculator.CalculateGameScore(lines, false);
        
        //Assert
        answer.Should().Be(12429);
    }



    
}