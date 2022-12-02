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
            case "C Y":
                return 2;
                break;            
            case "A Z":
                return 3;
                break;
            case "A X":
                return 4;
                break;
            case "B Y":
                return 5;
                break;
            case "C Z":
                return 6;
                break;
            case "C X":
                return 7;
                break;
            case "A Y":
                return 8;
                break;
            case "B Z":
                return 9;
                break;
            default:
                return 0;
                break;
        }
        
    }

    public int CalculateGameScore(IEnumerable<string> gameInput)
    {
        int total = 0;
        
        foreach (var round in gameInput)
        { 
            total += CalculateRoundScore(round);
        }

        return total;
    }
}