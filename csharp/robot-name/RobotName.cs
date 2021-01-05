using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercism.CSharp.Solutions.RobotNameExercise
{
    public class Robot
    {
        private static readonly HashSet<string> _allPossibleNames = GetAllPossibleNames();
        private static readonly HashSet<string> _takenNames = new HashSet<string>();

        public Robot() => Reset();

        public string Name { get; private set; }

        public void Reset()
        {
            if (_takenNames.Count == _allPossibleNames.Count)
            {
                throw new InvalidOperationException("There are no names left!");
            }

            if (_takenNames.Count == 0)
            {
                Name = _allPossibleNames.First();
                _takenNames.Add(Name);
            }
            else
            {
                string previousName = Name;
                Name = _allPossibleNames.Except(_takenNames).First();
                _takenNames.Remove(previousName);
                _takenNames.Add(Name);
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