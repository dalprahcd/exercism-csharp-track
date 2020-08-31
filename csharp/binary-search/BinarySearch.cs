namespace Exercism.CSharp.Solutions.BinarySearchExercise
{
    public static class BinarySearch
    {
        public static int Find(int[] input, int value)
        {
            int low = 0;
            int high = input.Length - 1;

            while (low <= high)
            {
                int mid = (high + low) / 2;

                if (input[mid] > value)
                {
                    high = mid - 1;
                }
                else if (input[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}