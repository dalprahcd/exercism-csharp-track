using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercism.CSharp.Solutions.RobotNameExercise
{
    public class Robot
    {
        private static readonly HashSet<string> allPossibleNames = GetAllPossibleNames();
        private static readonly HashSet<string> takenNames = new HashSet<string>();

        public Robot()
        {
            Reset();
        }

        public string Name { get; private set; }

        public void Reset()
        {
            if (takenNames.Count == allPossibleNames.Count)
            {
                throw new InvalidOperationException("There are no names left!");
            }

            if (takenNames.Count == 0)
            {
                Name = allPossibleNames.First();
                takenNames.Add(Name);
            }
            else
            {
                string previousName = Name;
                Name = allPossibleNames.Except(takenNames).First();
                takenNames.Remove(previousName);
                takenNames.Add(Name);
            }
        }

        private static HashSet<string> GetAllPossibleNames()
        {
            HashSet<string> names       = new HashSet<string>();
            StringBuilder nameBuilder   = new StringBuilder(5);
            char firstLetter            = 'A';
            char secondLetter           = 'A';
            int number                  = 000;
            bool keepGoing              = true;

            do
            {
                nameBuilder
                    .Append(firstLetter)
                    .Append(secondLetter)
                    .AppendFormat("{0:000}", number);

                names.Add(nameBuilder.ToString());
                nameBuilder.Clear();

                number++;
                if (number == 999)
                {
                    number = 0;
                    secondLetter++;
                    if (secondLetter == 'Z')
                    {
                        secondLetter = 'A';
                        firstLetter++;
                        if (firstLetter == 'Z')
                        {
                            keepGoing = false;
                        }
                    }
                }
            }
            while (keepGoing);

            return names;
        }
    }
}