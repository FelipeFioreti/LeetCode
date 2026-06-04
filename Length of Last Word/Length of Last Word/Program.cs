
Console.WriteLine(LengthOfLastWord("a"));

int LengthOfLastWord(string s)
{
    string worldWithTrim = s.Trim();
    int worldLength = worldWithTrim.Length;
    int res = 0;

    for (int i = worldLength - 1; i >= 0; i--)
    {
        if(worldWithTrim[i] == ' ')
        {
            break;
        }
        res++;
    }
    return res;

}