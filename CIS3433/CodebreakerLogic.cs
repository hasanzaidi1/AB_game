using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3433
{
    public class CodebreakerLogic
    {
        public List<string> PossibleNumbers { get; private set; }
        public string LastGeneratedNumber { get; private set; }
        private Random random = new Random();

        public CodebreakerLogic()
        {
            GenerateAllPossibleNumbers();
        }

        public void GenerateAllPossibleNumbers()
        {
            PossibleNumbers = new List<string>();
            for (int i = 1234; i <= 9876; i++)
            {
                string num = i.ToString();
                if (num.Distinct().Count() == 4)  // No repeated digits
                {
                    PossibleNumbers.Add(num);
                }
            }
        }

        public string GenerateNumber()
        {
            if (PossibleNumbers.Count == 0)
            {
                return null;
            }
            LastGeneratedNumber = PossibleNumbers[random.Next(PossibleNumbers.Count)];
            return LastGeneratedNumber;
        }

        public bool ApplyHints(int correctPositions, int wrongPositions)
        {
            if (!IsValidHint(correctPositions, wrongPositions))
                return false;

            var previousCount = PossibleNumbers.Count;
            PossibleNumbers = PossibleNumbers.Where(num => MatchesHints(num, correctPositions, wrongPositions)).ToList();
            return true;
        }

        private bool IsValidHint(int correctPositions, int wrongPositions)
        {
            int totalHints = correctPositions + wrongPositions;
            return totalHints <= LastGeneratedNumber.Distinct().Count();
        }

        private bool MatchesHints(string number, int correctPositions, int wrongPositions)
        {
            int correct = 0, wrong = 0;
            var possibleMatch = LastGeneratedNumber;
            for (int i = 0; i < 4; i++)
            {
                if (number[i] == LastGeneratedNumber[i])
                {
                    correct++;
                    possibleMatch = possibleMatch.Remove(i, 1).Insert(i, "_");
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (number[i] != LastGeneratedNumber[i] && possibleMatch.Contains(number[i]))
                {
                    int index = possibleMatch.IndexOf(number[i]);
                    possibleMatch = possibleMatch.Remove(index, 1).Insert(index, "_");
                    wrong++;
                }
            }
            return correct == correctPositions && wrong == wrongPositions;
        }
    }
}

