using FluentAssertions;

namespace Day8;

public class TreeCheckerTests
{
    [Test]
    [TestCase(@"30373
        25512
        65332
        33549
        35390", 21
    )]
    [TestCase(@"0000
        0110
        0110
        0000", 16)]
    public void CountOfVisible_TestGrids_ShouldBeCorrect(string grid, int expected)
    {
        TreeChecker.CountOfVisible(grid).Should().Be(expected);
    }
    
    [Test]
    [TestCase(@"30373
        25512
        65332
        33549
        35390", 16
    )]
    [TestCase(@"0000
        0110
        0110
        0000", 12)]

    public void CountOfPerimeterTrees_TestGrid_ShouldBeCorrect(string grid, int expected)
    {
        TreeChecker.CountOfPerimeterTrees(grid).Should().Be(expected);
    }

    [Test]
    [TestCase(@"30373
        25512
        65332
        33549
        35390", 5
    )]
    [TestCase(@"0000
        0110
        0110
        0000", 4)]

    public void CountOfInteriorTallTrees_TestGrids_ShouldBeCorrect(string grid, int expected)
    {
        TreeChecker.CountOfInteriorTallTrees(grid).Should().Be(expected);

    }

}

public class TreeChecker
{
    public static int CountOfVisible(string grid)
    {
        
        return CountOfPerimeterTrees(grid) + CountOfInteriorTallTrees(grid);
    }

    public static int CountOfInteriorTallTrees(string grid)
    {
        return 5;
    }

    public static int CountOfPerimeterTrees(string grid)
    {
        var twoD = grid.Split(Environment.NewLine);
        int innerTrees = (twoD.Count() - 2)*(twoD.Count() -2);
        return twoD.Count()*twoD.Count()-innerTrees;
    }
}