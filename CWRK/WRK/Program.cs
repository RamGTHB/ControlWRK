Console.Clear();

string PrintArray(string[] array)
{
    return $"[{String.Join(", ", array)}]";
}

int SearchString3(string[] array)
{
    int counter = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] GenArray2(string[] array)
{
    string[] resultArray = new string[SearchString3(array)];
    int j = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            resultArray[j] = $"\"{item}\"";
            j++;
        }
    }
    return resultArray;
}

string[] arr = new string[]{"a", "abdgf", ":-)", "sdafs", "Hook", "-2", "56566", "fox", "dog", "-0897865775655", "beer"};
string[] resultArray = GenArray2(arr);

Console.WriteLine($"{PrintArray(arr)} -> {PrintArray(resultArray)}\n");
