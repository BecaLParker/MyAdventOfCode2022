using FluentAssertions;

namespace DAy6;

public class Tests
{
    [Test]
    [TestCase("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
    [TestCase("nppdvjthqldpwncqszvftbrmjlhg", 6)]
    [TestCase("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
    [TestCase("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11)]
    public void FindMarkerShouldReturnEndPositionOfFirstMarkerInSignal(string signal, int expected)
    {
        //Arrange
        var processor = new SignalProcessor();
        
        //Act
        var result = processor.FindMarker(signal);
        
        //Assert
        result.Should().Be(expected);
    }
}