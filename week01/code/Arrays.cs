public static class Arrays
{
    public static double[] MultiplesOf(double number, int length)
    {
        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }
// 1. Create an array with the requested length.
// 2. Loop through each position in the array.
// 3. Multiply the starting number by the position + 1.
// 4. Store the result in the array.
// 5. Return the completed array.

    public static void RotateListRight(List<int> data, int amount)
    {
        List<int> temp = new List<int>(data);
        for (int i = 0; i < data.Count; i++)
        {
            data[(i + amount) % data.Count] = temp[i];
        }
    }
}
// 1. Make a copy of the original list so the original values aren't lost.
// 2. Loop through each item in the original list.
// 3. Calculate the new position by adding the rotation amount.
// 4. Use modulo to wrap the position back to the beginning when needed.
// 5. Put each original value into its new position.