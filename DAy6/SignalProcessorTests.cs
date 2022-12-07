using FluentAssertions;

namespace DAy6;

public class Tests
{
    [Test]
    [TestCase("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
    public void FindStartShouldReturnStartPositionOfFirstMarkerInSignal(string signal, int expected)
    {
        //Arrange
        var processor = new SignalProcessor();
        
        //Act
        var result = processor.FindMarker(signal);
        
        //Assert
        result.Should().Be(expected);
    }
}