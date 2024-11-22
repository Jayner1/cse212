public static class DisplaySums
{
    public static void Run()
    {
        DisplaySumPairs(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        // Should show something like (order does not matter):
        // 6 4
        // 7 3
        // 8 2
        // 9 1 

        Console.WriteLine("------------");
        DisplaySumPairs(new int[] { -20, -15, -10, -5, 0, 5, 10, 15, 20 });
        // Should show something like (order does not matter):
        // 10 0
        // 15 -5
        // 20 -10

        Console.WriteLine("------------");
        DisplaySumPairs(new int[] { 5, 11, 2, -4, 6, 8, -1 });
        // Should show something like (order does not matter):
        // 8 2
        // -1 11
    }

    /// <summary>
    /// Display pairs of numbers (no duplicates should be displayed) that sum to
    /// 10 using a set in O(n) time. We are assuming that there are no duplicates
    /// in the list.
    /// </summary>
    /// <param name="numbers">array of integers</param>
    private static void DisplaySumPairs(int[] numbers)
    {
        HashSet<int> numbersSet = new HashSet<int>(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            int numberNeeded = 10 - numbers[i];
            if (numbersSet.Contains(numberNeeded) && numberNeeded != numbers[i])
            {
                Console.WriteLine($"{numbers[i]} {numberNeeded}");
                numbersSet.Remove(numbers[i]);
                numbersSet.Remove(numberNeeded); // Remove the pair to avoid duplicates
            }
        }
    }
}