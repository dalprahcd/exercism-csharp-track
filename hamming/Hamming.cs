using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.HammingExercise
{
    public static class Hamming
    {
        public static int Distance(string firstStrand, string secondStrand)
        {
            if (firstStrand == null || secondStrand == null)
            {
                throw new ArgumentException();
            }

            if (firstStrand.Length != secondStrand.Length)
            {
                throw new ArgumentException();
            }

            int hammingDistance = 0;
            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] != secondStrand[i])
                {
                    hammingDistance++;
                }
            }

            return hammingDistance;
        }
    }
}