public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    
    // Step 1: Create a new array of type double with size equal to the count of multiples
    // Step 2: Use a loop that runs 'length' times
    // Step 3: In each loop iteration, multiply the number by (i + 1)
    // Step 4: Store the result in the array at index i
    // Step 5: After the loop, return the array

    public static double[] MultiplesOf(double number, int length)
    {
        double[] result = new double[length]; // Step 1

        for (int i = 0; i < length; i++) // Step 2
        {
            result[i] = number * (i + 1); // Step 3–4
        }

        return result; // Step 5
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount is 3,
    /// then the result should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// This method modifies the existing list.
    /// </summary>

    // Step 1: Calculate the index where rotation should begin (data.Count - amount)
    // Step 2: Use GetRange to extract the last 'amount' elements into a new list
    // Step 3: Use GetRange again to extract the beginning portion (everything before the split)
    // Step 4: Clear the original list
    // Step 5: Add the two extracted ranges back into the original list in the rotated order

    public static void RotateListRight(List<int> data, int amount)
    {
        int splitIndex = data.Count - amount; // Step 1

        List<int> endPart = data.GetRange(splitIndex, amount); // Step 2
        List<int> startPart = data.GetRange(0, splitIndex);    // Step 3

        data.Clear(); // Step 4
        data.AddRange(endPart);  // Step 5a
        data.AddRange(startPart); // Step 5b
    }
}
