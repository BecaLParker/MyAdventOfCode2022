namespace Day2;

public class Scorer
{
    public int CalculateScore(string input)
    {
        switch (input)
        {
            case "B X":
                return 1;
                break;
            case "Z C":
                return 6;
                break;
            default:
                return 0;
                break;
        }
        
    }
}