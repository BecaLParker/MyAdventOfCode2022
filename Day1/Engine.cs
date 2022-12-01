namespace Day1;

public class Engine
{
    public int MostCalories(IEnumerable<Elf> elves)
    {
        return elves.Any() ? elves.Select(x => x.TotalCalories()).Max() : 0;
    }
}