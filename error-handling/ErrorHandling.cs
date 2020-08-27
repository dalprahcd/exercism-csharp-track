using System;

namespace Exercism.CSharp.Solutions.ErrorHandlingExercise
{
    public static class ErrorHandling
    {
        public static void HandleErrorByThrowingException() =>
            throw new Exception("Error message");

        public static int? HandleErrorByReturningNullableType(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch
            {
                return null;
            }
        }

        public static bool HandleErrorWithOutParam(string input, out int result) =>
            int.TryParse(input, out result);

        public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
        {
            using (disposableObject)
            {
                throw new Exception("Error message");
            }
        }
    }
}