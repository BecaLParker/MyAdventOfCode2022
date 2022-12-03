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
        var bag1 = "vJrwpWtwJgWrhcsFMMfFFhFp";
        var bag2 = "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL";
        var app = new App();

        //Act
        var bag1Result = app.SearchBag(bag1);
        var bag2Result = app.SearchBag(bag2);

        //Assert
        bag1Result.Should().Be("p", "The only item type that appears in both compartments is lowercase p.");
        bag2Result.Should().Be("L");
    }
}