
int[] PlusOne(int[] digits)
{
    var result = digits.ToList();
    result.Reverse();

    if (result.First() == 9)
    {

        for (int i = 0; i < result.Count; i++)
        {
            if (result[i] == 9)
            {
                result[i] = 0;
                if ((i + 1) == result.Count)
                {
                    result.Insert(result.Count, 1);
                    break;
                }
            }
            else
            {
                result[i]++;
                break;
            }   
        }
    }
    else
    {
        result[0]++;
    }
    
    result.Reverse();
    return result.ToArray();

}

foreach (var item in PlusOne([9]))
{
    Console.WriteLine(item);
}
