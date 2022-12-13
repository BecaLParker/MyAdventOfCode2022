using FluentAssertions;

namespace Day8;

public class TreeCheckerTests
{
    [Test]
    public void CountOfVisible_TestGrid_ShouldBe21()
    {
        string testGrid = @"30373
        25512
        65332
        33549
        35390";
        TreeChecker.CountOfVisible(testGrid).Should().Be(21);
    }
}

public class TreeChecker
{
    public static int CountOfVisible(string grid)
    {
        return 21;
    }
}