string[] inputArray = new string[5] { "Hi", "from", "Alex", "Kopylov", ":-)" };
PrintArray(inputArray, "Input");
PrintArray(FilterArray(inputArray), "Output");

string[] FilterArray(string[] inputArr)
{
    string[] resultArr = new string[CheckLength(inputArr)];
    int count = 0;
    for (int i = 0; i < inputArr.GetLength(0); i++)
    {
        if (inputArr[i].Length <= 3)
        {
            resultArr[count] = inputArr[i];
            count++;
        }
    }
    return resultArr;
}
void PrintArray(string[] inputArr, string nameArray)
{
    string result = "[ ";
    for (int i = 0; i < inputArr.GetLength(0); i++)
    {
        result += "\"" + inputArr[i] + "\" ";
    }
    result += "]";
    Console.WriteLine($"{nameArray} array: {result}");
}
int CheckLength (string[] inputArr)
{
    int count = 0;
    for (int i = 0; i < inputArr.GetLength(0); i++)
    {
        if (inputArr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}