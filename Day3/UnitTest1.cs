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
        var bag3 = "PmmdzqPrVvPwwTWBwg";
        var bag4 = "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn";
        var bag5 = "ttgJtRGJQctTZtZT";
        var bag6 = "CrZsJsPPZsGzwwsLwLmpwMDw";
        var app = new App();

        //Act
        var bag1Result = app.SearchBag(bag1);
        var bag2Result = app.SearchBag(bag2);
        var bag3Result = app.SearchBag(bag3);
        var bag4Result = app.SearchBag(bag4);
        var bag5Result = app.SearchBag(bag5);
        var bag6Result = app.SearchBag(bag6);

        //Assert
        bag1Result.Should().Be("p", "The only item type that appears in both compartments is lowercase p.");
        bag2Result.Should().Be("L");
        bag3Result.Should().Be("P");
        bag4Result.Should().Be("v");
        bag5Result.Should().Be("t");
        bag6Result.Should().Be("s");
    }
}