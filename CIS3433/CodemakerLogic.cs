using System;
using System.Collections.Generic;

namespace CIS3433
{
    public class CodemakerLogic
    {
        public string SecretNumber { get; private set; }

        public CodemakerLogic()
        {
            GenerateSecretNumber();
        }

        public void GenerateSecretNumber()
        {
            Random rnd = new Random();
            List<int> digits = Enumerable.Range(1, 9).ToList();
            SecretNumber = digits[rnd.Next(0, digits.Count)].ToString();
            digits = Enumerable.Range(0, 10).Except(new int[] { int.Parse(SecretNumber) }).ToList();

            while (SecretNumber.Length < 4)
            {
                int index = rnd.Next(0, digits.Count);
                SecretNumber += digits[index];
                digits.RemoveAt(index);
            }
        }

        public string GenerateHint(string guess)
        {
            int A = 0, B = 0;
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == SecretNumber[i])
                {
                    A++;
                }
                else if (SecretNumber.Contains(guess[i]))
                {
                    B++;
                }
            }
            return $"{A}A{B}B";
        }

       
    }
}



