namespace Day1;

public class ElfFactory
{
    public IEnumerable<Elf> Create(string inputPath)
    {
        var elves = new List<Elf>();
        
        if (File.Exists(inputPath))
        {
            var lines = File.ReadAllText(inputPath).Split(Environment.NewLine);
            var elfInProgress = new Elf(new List<int>());
            foreach (string line in lines)
            {
                if (line == "")
                {
                    elves.Add(elfInProgress);
                    elfInProgress = new Elf(new List<int>());
                }
                else
                {
                    int snack = Int32.Parse(line);
                    elfInProgress.AddSnack(snack);
                }
            }
            
            
        }
        
        return elves;
    }
}