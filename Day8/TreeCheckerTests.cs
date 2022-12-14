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

public static class TreeChecker
{
    public static int CountOfVisible(string grid)
    {
        
        return CountOfPerimeterTrees(grid) + CountOfInteriorTallTrees(grid);
    }

    public static int CountOfInteriorTallTrees(string grid)
    {
        var treeRows = grid.Split(Environment.NewLine);
        var treeColumns = new List<string>();
        for (int i = 0; i < treeRows[0].Count(); i++)
        {
            treeColumns.Add(new string(treeRows.Select(x => x[i]).ToArray()));
        }
        
        var visibleTrees = 0;

        for (int i = 1; i < treeRows[0].Count() -1; i++)
        {
            var row = treeRows[i];
            for (int j = 1; j < row.Count() -1; j++)
            {
                var tree = row[j];
                //Look East and West
                if (tree >= row.Remove(j).Max())
                {
                    visibleTrees++;
                }
            }
        }
        
        for (int k = 1; k < treeColumns[0].Count() -1; k++)
        {
            var column = treeColumns[k];
            for (int l = 1; l < column.Count() -1; l++)
            {
                var tree = column[l];
                //Look North and South
                if (tree >= column.Remove(l).Max())
                {
                    visibleTrees++;
                }
            }
        }
        
        // TODO: Are we incrementing visibleTrees twice if a tree is visible in more than one direction? Use or logic
        
        return visibleTrees;
    }

    public static int CountOfPerimeterTrees(string grid)
    {
        var twoD = grid.Split(Environment.NewLine);
        int innerTrees = (twoD.Count() - 2)*(twoD.Count() -2);
        return twoD.Count()*twoD.Count()-innerTrees;
    }
}