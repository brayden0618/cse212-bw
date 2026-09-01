Console.WriteLine("\n======================\nMultiplesOf\n======================");
double[] multiples = Arrays.MultiplesOf(7, 5);
Console.WriteLine("Result: [" + string.Join(", ", multiples) + "]");

Console.WriteLine("\n======================\nRotateListRight\n======================");
List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine("Original: [" + string.Join(", ", list) + "]");
Arrays.RotateListRight(list, 3);
Console.WriteLine("After rotation: [" + string.Join(", ", list) + "]");