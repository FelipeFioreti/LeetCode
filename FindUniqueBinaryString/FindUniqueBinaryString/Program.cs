
Console.WriteLine(FindDifferentBinaryString(["111", "011", "001"]));

static string FindDifferentBinaryString(string[] nums)
{

    char[] res = new char[nums[0].Length];

    for (int i = 0; i < nums[0].Length; i++)
    {
        res[i] = '0';
    }

    while (nums.Contains(new string(res)))
    {
        for (int i = res.Length - 1; i >= 0; i--)
        {
            if (res[i] == '0')
            {
                res[i] = '1';
                break;
            }

            res[i] = '0';
        }
    }

    return new string(res);
}