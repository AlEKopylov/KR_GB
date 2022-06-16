string[] inputArray = new string[5] {"Hi", "from", "Alex", "Kopylov", ":-)"};

string[] ClearArray(string[] inputArr) //Create new array
{
    string[] resultArr = new string[inputArr.GetLength(0)];
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