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
        var result = calculator.CalculateRoundScore(roundInput);
        
        //Assert
        result.Should().Be(1);
    }
    
    [Test]
    public void CalculateRoundScore_ZvsC_ShouldReturn6()
    {
        //Arrange
        var roundInput = "Z C";
        var calculator = new Scorer();

        //Act
        var result = calculator.CalculateRoundScore(roundInput);
        
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
        var result = calculator.CalculateRoundScore(roundInput);
        
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
        var result = calculator.CalculateGameScore(gameInput);
        
        //Assert
        result.Should().Be(15);
    }



    
}