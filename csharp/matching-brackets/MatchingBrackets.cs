using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.MatchingBracketsExercise
{
    public static class MatchingBrackets
    {
        private static readonly Dictionary<char, char> _wrapperPairs = new Dictionary<char, char>
        {
            ['('] = ')',
            ['['] = ']',
            ['{'] = '}'
        };

        public static bool IsPaired(string input)
        {
            var wrappersToCheck = new Stack<char>();

            foreach (var wrapper in input.Where(IsWrapper))
            {
                if (_wrapperPairs.Keys.Contains(wrapper))
                {
                    // It is a opening wrapper, add to the stack.
                    wrappersToCheck.Push(wrapper);
                }
                else if (wrappersToCheck.Count > 0)
                {
                    // It is a closing wrapper with existing opening wrapper on the stack
                    // check if it is the correct pair
                    if (!wrappersToCheck.Peek().IsCorrectPair(wrapper))
                    {
                        return false;
                    }

                    // remove this opening wrapper from the stack
                    _ = wrappersToCheck.Pop();
                }
                else
                {
                    // It is a closing wrapper without a opening wrapper.
                    return false;
                }
            }

            // All opening wrappers should have been matched.
            return wrappersToCheck.Count == 0;
        }

        private static bool IsWrapper(this char ch) =>
            _wrapperPairs.Keys.Contains(ch) || _wrapperPairs.Values.Contains(ch);

        private static bool IsCorrectPair(this char opening, char closing) =>
            _wrapperPairs[opening] == closing;
    }
}