namespace Day1;

public class Elf
{
    private List<int> _snacks;
    public Elf(List<int> snacks)
    {
        _snacks = snacks;
    }
    public int TotalCalories()
    {
        return _snacks.Sum();
    }
    public void AddSnack(int snack)
    {
        _snacks.Add(snack);
    }
}