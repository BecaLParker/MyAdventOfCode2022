using FluentAssertions;
namespace Day8;

public class ForestSurveyorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CountOfVisibleTreesShouldReturnCorrectCount()
    {
        //Arrange
        string testGrid = @"30373
25512
65332
33549
35390";
        var surveyor = new ForestSurveyor();

        //Act
        var result = surveyor.CountOfVisibleTrees(testGrid);
        
        //Assert
        result.Should().Be(21);
    }

    /*[Test]
    [TestCase(@"30373
25512
65332
33549
35390", 16 )]
    [TestCase(@"3037
2551
6533
3354", 12 )]
    public void CountOfPerimeterTrees_Grid_ShouldReturnCorrectPerimeter(string grid, int expectedPerimeterCount)
    {
        //Arrange
        var surveyor = new ForestSurveyor();
        
        //Act
        var result = surveyor.CountPerimeterTrees(grid);
        
        //Assert
        result.Should().Be(expectedPerimeterCount);
    }
}*/

public class ForestSurveyor
{
    public object CountOfVisibleTrees(string testGrid)
    {
        throw new NotImplementedException();
    }
}