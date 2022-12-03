namespace Day3;

public class App
{
    public string SearchBag(string bag)
    {
        var firstCompartment = bag.Substring(0, bag.Length / 2);
        var secondCompartment = bag.Substring(bag.Length / 2, bag.Length / 2);
        
        return firstCompartment.Intersect(secondCompartment).First().ToString();
    }

    public int ItemPriority(string item)
    {
        var character = item[0];
        if (Char.IsLower(character))
        {
            return character - 96;
        }
        else
        {
            return character - 38;
        }
    }

    public int PrioritySum(IEnumerable<string> bags)
    {
        return bags.Select(bag => ItemPriority(SearchBag(bag))).Sum();
    }
}