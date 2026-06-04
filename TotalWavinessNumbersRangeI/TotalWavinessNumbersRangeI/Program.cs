int TotalWaviness(int num1, int num2)
{
    int res = 0;

    for (int i = num1; i <= num2; i++)
    {
        string numToCompare = i.ToString();
        
        for (int j = 1; j < numToCompare.Length - 1; j++)
        {
            if ((numToCompare[j] - numToCompare[j - 1]) * (numToCompare[j] - numToCompare[j + 1]) > 0)
            {
                res++;
            }
            
        }
        
    }

    return res;
}

Console.WriteLine(TotalWaviness(4848, 4848));

