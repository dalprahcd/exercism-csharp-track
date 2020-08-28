using System;
using System.Collections.Generic;
using System.Text;

namespace Exercism.CSharp.Solutions.RobotNameExercise
{
    public class Robot
    {
        private static readonly Random random = new Random();
        private static readonly HashSet<string> existingNames = new HashSet<string>();

        public Robot()
        {
            Reset();
        }

        public string Name { get; private set; }

        public bool Reset()
        {
            // There is no new possible names.
            if (existingNames.Count == (26 * 26 * 999) - 1) // Not sure about the maximum number
            {
                return false;
            }

            StringBuilder nameBuilder = new StringBuilder();

            do
            {
                nameBuilder.Clear();
                nameBuilder
                    .AppendFormat("{0}", (char)random.Next('A', 'Z'))
                    .AppendFormat("{0}", (char)random.Next('A', 'Z'))
                    .AppendFormat("{0:000}", random.Next(0, 999));
            }
            while (!existingNames.Add(nameBuilder.ToString()));

            Name = nameBuilder.ToString();
            return true;
        }
    }
}