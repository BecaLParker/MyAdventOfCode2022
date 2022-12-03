using FluentAssertions;

namespace Day3;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SearchBagShouldReturnCorrectItem()
    {
        //Arrange
        //The first rucksack contains the items vJrwpWtwJgWrhcsFMMfFFhFp, 
        //which means its first compartment contains the items vJrwpWtwJgWr, 
        //while the second compartment contains the items hcsFMMfFFhFp.
        var firstBag = "vJrwpWtwJgWrhcsFMMfFFhFp";
        var app = new App();

        //Act
        var result = app.SearchBag(firstBag);

        //Assert
        result.Should().Be("p", "The only item type that appears in both compartments is lowercase p.");
    }
}