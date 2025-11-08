using System;
using System.Collections.Generic;
using System.Diagnostics;

public static class Arrays
{
    // PLAN for MultiplesOf:
    // 1. Create an array that can hold 'count' number of values.
    // 2. Loop from 0 up to count - 1.
    // 3. For each position i, store start * (i + 1) in the array.
    // 4. Return the array.

    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create a new array with the specified length
        double[] multiples = new double[length];
        
        // Step 2: Loop through each position in the array
        for (int i = 0; i < length; i++)
        {
            // Step 3: Calculate the multiple and store it in the array
            // We use (i + 1) because we want the first multiple to be number * 1, not number * 0
            multiples[i] = number * (i + 1);
        }
        
        // Step 4: Return the completed array
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN for RotateListRight:
        // 1. Calculate the split point: data.Count - amount (this tells us where to divide the list)
        // 2. Get the portion from the split point to the end (these elements will move to the front)
        // 3. Get the portion from the beginning to the split point (these elements will move to the back)
        // 4. Clear the original list
        // 5. Add the end portion first (the elements that were at the end)
        // 6. Add the beginning portion second (the elements that were at the beginning)
        
        // Step 1: Calculate where to split the list
        // The rotation amount tells us how many elements from the end should move to the front
        int splitIndex = data.Count - amount;
        
        // Step 2: Get the portion from the split point to the end
        // These are the elements that will move to the front of the list
        List<int> endPortion = data.GetRange(splitIndex, amount);
        
        // Step 3: Get the portion from the beginning to the split point
        // These are the elements that will move to the back of the list
        List<int> beginningPortion = data.GetRange(0, splitIndex);
        
        // Step 4: Clear the original list so we can rebuild it
        data.Clear();
        
        // Step 5: Add the end portion first (elements that were at the end)
        data.AddRange(endPortion);
        
        // Step 6: Add the beginning portion second (elements that were at the beginning)
        data.AddRange(beginningPortion);
    }
}