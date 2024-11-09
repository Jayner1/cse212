public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Define an array to store multiples of 'number', with a length equal to 'length'.
        double[] multiples = new double[length];
        
        // Step 2: Loop through 'length' times to calculate and store each multiple in the array.
        for (int i = 0; i < length; i++)
        {
            // Step 3: Calculate the multiple as 'number * (i + 1)'.
            multiples[i] = number * (i + 1);
        }
        
        // Step 4: Return the array containing the multiples.
        return multiples;
    }
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Determine the effective rotation using modulus.
        int effectiveRotation = amount % data.Count;
        
        // Step 2: Extract the last 'effectiveRotation' elements.
        List<int> rightPart = data.GetRange(data.Count - effectiveRotation, effectiveRotation);
        
        // Step 3: Extract the remaining elements from the start to 'data.Count - effectiveRotation'.
        List<int> leftPart = data.GetRange(0, data.Count - effectiveRotation);
        
        // Step 4: Clear the original list and add back the elements in the rotated order.
        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}
