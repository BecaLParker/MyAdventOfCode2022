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

    [Test]
    public void ItemPriorityShouldReturnCorrectValue()
    {
        //Arrange
        var bag1Item = "p";
        var bag2Item = "L";
        var bag3Item = "P";
        var bag4Item = "v";
        var bag5Item = "t";
        var bag6Item = "s";
        
        var app = new App();

        //Act
        var item1Result = app.ItemPriority(bag1Item);
        var item2Result = app.ItemPriority(bag2Item);
        var item3Result = app.ItemPriority(bag3Item);
        var item4Result = app.ItemPriority(bag4Item);
        var item5Result = app.ItemPriority(bag5Item);
        var item6Result = app.ItemPriority(bag6Item);

        //Assert
        item1Result.Should().Be(16, "Lowercase item types a through z have priorities 1 through 26.");
        item2Result.Should().Be(38, "Uppercase item types A through Z have priorities 27 through 52.");
        item3Result.Should().Be(42);
        item4Result.Should().Be(22);
        item5Result.Should().Be(20);
        item6Result.Should().Be(19);
    }

    [Test]
    public void PrioritySumForThe6TestBagsShouldReturn157()
    {
        //Arrange
        var sixTestBags = new string[6]
        {
            "vJrwpWtwJgWrhcsFMMfFFhFp", 
            "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", 
            "PmmdzqPrVvPwwTWBwg", 
            "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", 
            "ttgJtRGJQctTZtZT",
            "CrZsJsPPZsGzwwsLwLmpwMDw"
        };
        var app = new App();

        //Act
        var result = app.PrioritySum(sixTestBags);
        
        //Assert
        result.Should().Be(157);
    }

    [Test]
    public void GetDay3FirstStar()
    {
        string day3InputPath = @"C:\AdventOfCode2022\Day3\Day3Input.txt";
        var bags = File.ReadAllText(day3InputPath).Split(Environment.NewLine);
        var app = new App();

        Console.WriteLine(app.PrioritySum(bags));
    }

    [Test]
    public void GetDay3SecondStar()
    {
        string day3InputPath = @"C:\AdventOfCode2022\Day3\Day3Input.txt";
        var bags = File.ReadAllText(day3InputPath).Split(Environment.NewLine);
        var app = new App();

        Console.WriteLine(app.BadgePrioritySum(bags));
    }
}