using System;

namespace Exercism.CSharp.Solutions.TwoFerExercise
{
    public static class TwoFer
    {
        // In order to get the tests running, first you need to make sure the Speak method 
        // can be called both without any arguments and also by passing one string argument.
        public static string Speak(string name = "you")
        {
            if (string.IsNullOrWhiteSpace(name)) { name = "you"; }
            return $"One for {name}, one for me.";
        }
    }
}