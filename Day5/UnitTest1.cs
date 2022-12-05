using System.Net.Http.Headers;

namespace Day5;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CanIDoItWithoutWritingUnitTests()
    {
        //Arrange
        var testInput = "";
        var crane = new Crane();
        
        //Act
        //Assert
    }
};

public class Crane
{
    public List<Stack<string>> GetInitialCrateStack()
    {
        var stacks = new List<Stack<string>>();
        Stack<string> stack1 = new Stack<string>(new [] {"H", "B", "V", "W", "N", "M", "L", "P" });
        Stack<string> stack2 = new Stack<string>(new [] {"M", "Q", "H"});
        Stack<string> stack3 = new Stack<string>(new [] {"N", "D", "B", "G", "F", "Q", "M", "L"});
        Stack<string> stack4 = new Stack<string>(new [] {"Z", "T", "F", "Q", "M", "W", "G"});
        Stack<string> stack5 = new Stack<string>(new [] {"M","T","H","P"});
        Stack<string> stack6 = new Stack<string>(new [] {"C", "B", "M", "J", "D", "H", "G", "T"});
        Stack<string> stack7 = new Stack<string>(new [] {"M", "N", "B", "F", "V", "R"});
        Stack<string> stack8 = new Stack<string>(new [] {"P", "L", "H", "M", "R", "G", "S"});
        Stack<string> stack9 = new Stack<string>(new [] {"P","D","B","C","N"});
        
        stacks.Add(stack1);
        stacks.Add(stack2);
        stacks.Add(stack3);
        stacks.Add(stack4);
        stacks.Add(stack5);
        stacks.Add(stack6);
        stacks.Add(stack7);
        stacks.Add(stack8);
        stacks.Add(stack9);

        return stacks;
    }

    public List<Stack<string>> ProcessMove(string move, List<Stack<string>> inputStacks = null)
    {
        int quantity = Int32.Parse((string) move.Split("from")[0].Where(Char.IsDigit));
        int from = Int32.Parse((string) move.Split("from")[1].Split("to")[0].Where(Char.IsDigit));
        int to = Int32.Parse((string) move.Split("from")[1].Split("to")[1].Where(Char.IsDigit));

        var stacks = inputStacks;
        if (stacks == null)
        {
            stacks = GetInitialCrateStack();
        }
        
        //Do this quantity times
        for (int i = 0; i < quantity; i++)
        {
            stacks[to - 1].Push(stacks[from - 1].Pop());
        }

        return stacks;
    }
    
    //Add a method to iterate through only the lines of inout file tht are move lines
    //Add a method to return the top item of each stack
}