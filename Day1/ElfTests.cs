using FluentAssertions;

namespace Day1;

public class ElfTests
{
    [Test]
    public void TotalCalories_With3x1CalorieSnacks_ShouldReturnThree()
    {
        //Arrange
        var testElf = new Elf(new List<int>() {1,1,1});

        //Act
        int result = testElf.TotalCalories();
        
        //Assert
        result.Should().Be(3);
    }
    
    [Test]
    public void TotalCalories_With3x2CalorieSnacks_ShouldReturnSix()
    {
        //Arrange
        var testElf = new Elf(new List<int>() {2,2,2});

        //Act
        int result = testElf.TotalCalories();
        
        //Assert
        result.Should().Be(6);
    }
}