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
        return 16;
    }
}