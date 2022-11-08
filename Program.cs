// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] arrayString = { "English", "1", "Russia", "Chuvash", "356" };
int lengthArray = arrayString.Length;



void ArrayPrintOut(string[] input)
{
    Console.WriteLine("[" + string.Join(", ", input) + "]");
}

string[] ArraySorter(string[] input, int lengthToShow)
{
    List<string> sortedOut = new List<string>();
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= lengthArray)
            sortedOut.Add(input[i]);
    }
    string[] sortedArray = new string[sortedOut.Count];
    for (int i = 0; i < sortedOut.Count; i++)
        sortedArray[i] = sortedOut[i];
    return sortedArray;
}

Console.WriteLine("unsorted: ");
ArrayPrintOut(arrayString);
string[] srtArray = ArraySorter(arrayString, lengthArray);
Console.WriteLine("sorted: ");
ArrayPrintOut(srtArray);