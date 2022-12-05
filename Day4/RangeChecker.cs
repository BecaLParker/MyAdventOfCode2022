namespace Day4
{
    internal class RangeChecker
    {
        internal bool IsFullyContained(string pair)
        {
            //populate the lists
            var split = pair.Split(",");
            var aStart = Int32.Parse(split[0].Split("-")[0]);
            var aEnd = Int32.Parse(split[0].Split("-")[1]);
            var bStart = Int32.Parse(split[1].Split("-")[0]);
            var bEnd = Int32.Parse(split[1].Split("-")[1]);
            var a = Enumerable.Range(aStart, aEnd - aStart +1).ToList();
            var b = Enumerable.Range(bStart, bEnd - bStart +1).ToList();

            //return whether one contains the other
            bool answer = a.All(x => b.Any(y => x == y));
            if (answer)
            {
                return answer;
            }
            else
            {
                answer = b.All(x => a.Any(y => x == y));
            }

            return answer;
        }

        private bool IsPartiallyContained(string pair)
        {
            //populate the lists
            //TODO: extract method
            var split = pair.Split(",");
            var aStart = Int32.Parse(split[0].Split("-")[0]);
            var aEnd = Int32.Parse(split[0].Split("-")[1]);
            var bStart = Int32.Parse(split[1].Split("-")[0]);
            var bEnd = Int32.Parse(split[1].Split("-")[1]);
            var a = Enumerable.Range(aStart, aEnd - aStart +1).ToList();
            var b = Enumerable.Range(bStart, bEnd - bStart +1).ToList();

            //return whether one contains any of the other range
            bool answer = a.Any(x => b.Any(y => x == y));
            if (answer)
            {
                return answer;
            }
            else
            {
                answer = b.Any(x => a.Any(y => x == y));
            }

            return answer;
        }
        
        public int CheckAllPairs(string input, bool isPartOne)
        {
            var pairs = input.Split(Environment.NewLine);
            var partOneTotal = 0;
            var partTwoTotal = 0;
            foreach (var pair in pairs)
            {
                if (isPartOne && IsFullyContained(pair))
                {
                    partOneTotal += 1;
                }

                if (!isPartOne && IsPartiallyContained(pair))
                {
                    partTwoTotal += 1;
                }
            }

            return isPartOne ? partOneTotal : partTwoTotal;
        }

    }
}