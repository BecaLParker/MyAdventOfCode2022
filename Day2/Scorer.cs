namespace Day2;

public class Scorer
{
    public int CalculateRoundScore(string input)
    {
        switch (input)
        {
            case "B X":
                return 1;
                break;
            case "Z C":
                return 6;
                break;
            case "A Y":
                return 8;
                break;
            default:
                return 0;
                break;
        }
        
    }

    public int CalculateGameScore(List<string> gameInput)
    {
        int total = 0;
        
        foreach (var round in gameInput)
        { 
            total += CalculateRoundScore(round);
        }

        return total;
    }
}