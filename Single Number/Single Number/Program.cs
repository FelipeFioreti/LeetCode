
Console.WriteLine(SingleNumber([4, 1, 2, 1, 2]));
static int SingleNumber(int[] nums)
{
    #region First Solution
    //Dictionary<int, int> dict = new Dictionary<int, int>();

    //foreach (var num in nums)
    //{
    //    dict[num] = dict.GetValueOrDefault(num) + 1;
    //}

    //foreach (var kvp in dict)
    //{
    //    if (kvp.Value == 1)
    //    {
    //        return kvp.Key;
    //    }
    //}

    //return 0;
    #endregion

    #region Second Solution
    int count = 0;

    foreach (var num in nums)
    {
        count ^= num;
    }

    return count;
    #endregion
}
