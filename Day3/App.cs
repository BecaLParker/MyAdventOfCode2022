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

    public int BadgePrioritySum(IEnumerable<string> bags)
    {
        var groups = SplitIntoGroupsOfThree(bags);
        var badges = new List<string>();
        foreach (var group in groups)
        {
            var groupBagsAsListsOfChar = new List<List<char>>();
            foreach (var bag in group)
            {
                List<char> bagAsListOfChar = new List<char>();
                bagAsListOfChar.AddRange(bag);
                groupBagsAsListsOfChar.Add(bagAsListOfChar);
            }

            badges.Add(groupBagsAsListsOfChar[0].Intersect(groupBagsAsListsOfChar[1]).Intersect(groupBagsAsListsOfChar[2]).First().ToString()); 
        }

        var prioritySum = 0;
        foreach (var badge in badges)
        {
            prioritySum += ItemPriority(badge);
        }

        return prioritySum;
    }

    private static List<List<T>> SplitIntoGroupsOfThree<T>(IEnumerable<T> source)
    {
        return  source
            .Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / 3)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();
    }
}