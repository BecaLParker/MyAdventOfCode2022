namespace Day1;

public class Engine
{
    public int MostCalories(IEnumerable<Elf> elves)
    {
        return elves.Any() ? 1 : 0;
    }
}