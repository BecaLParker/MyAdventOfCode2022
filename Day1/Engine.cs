using System.Linq;

namespace Day1;

public class Engine
{
    public int MostCalories(IEnumerable<Elf> elves)
    {
        return elves.Any() ? elves.Select(x => x.TotalCalories()).Max() : 0;
    }

    public object CaloriesFromTopThree(IEnumerable<Elf> elves)
    {
        return elves.Any() ? elves.Select(x => x.TotalCalories()).OrderByDescending(x => x).Take(3).Sum() : 0;
    }
}