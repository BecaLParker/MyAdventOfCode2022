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
}