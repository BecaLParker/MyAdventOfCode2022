using FluentAssertions;

namespace Day2;

public class ScorerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CalculateScore_BvsX_ShouldReturn1()
    {
        //Arrange
        var roundInput = "B X";
        var calculator = new Scorer();

        //Act
        var result = calculator.CalculateScore(roundInput);
        
        //Assert
        result.Should().Be(1);
    }
    
    [Test]
    public void CalculateScore_ZvsC_ShouldReturn6()
    {
        //Arrange
        var roundInput = "Z C";
        var calculator = new Scorer();

        //Act
        var result = calculator.CalculateScore(roundInput);
        
        //Assert
        result.Should().Be(6);
    }
    
    [Test]
    public void CalculateScore_AvsY_ShouldReturn8()
    {
        //Arrange
        var roundInput = "A Y";
        var calculator = new Scorer();

        //Act
        var result = calculator.CalculateScore(roundInput);
        
        //Assert
        result.Should().Be(8);
    }



    
}