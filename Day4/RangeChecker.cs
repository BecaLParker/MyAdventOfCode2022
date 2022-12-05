namespace Day4
{
    internal class RangeChecker
    {
        public RangeChecker()
        {
        }

        internal bool IsFullyContained(string pair)
        {
            //populate the arrays
            var split = pair.Split(",");
            var aStart = Int32.Parse(split[0].Split("-")[0]);
            var aEnd = Int32.Parse(split[0].Split("-")[1]);
            var bStart = Int32.Parse(split[1].Split("-")[0]);
            var bEnd = Int32.Parse(split[1].Split("-")[1]);
            var a = Enumerable.Range(aStart, aEnd - aStart +1).ToList();
            var b = Enumerable.Range(bStart, bEnd - bStart +1).ToList();

            //return whether one contains the other
            bool answer = a.All(x => b.Any(y => x == y));
            if (answer == true)
            {
                return answer;
            }
            else
            {
                answer = b.All(x => a.Any(y => x == y));
            }

            return answer;
        }
    }
}