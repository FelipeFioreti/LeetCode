
string MergeAlternately1(string word1, string word2)
{
    string mergeString = "";

    if (word1.Length > word2.Length)
    {
        for (int i = 0; i < word2.Length; i++)
        {
            mergeString += word1[i];
            mergeString += word2[i];
        }

        mergeString += (word1.Substring(word2.Length));
    }else if (word2.Length > word1.Length)
    {
        for (int i = 0; i < word1.Length; i++)
        {
            mergeString += word1[i];
            mergeString += word2[i];
        }

        mergeString += (word2.Substring(word1.Length));
    }
    else
    {
        for (int i = 0; i < word1.Length; i++)
        {
            mergeString += word1[i];
            mergeString += word2[i];
        }
    }



    return mergeString;
}

MergeAlternately1("abcd", "pqrs");



string MergeAlternately2(string word1, string word2)
{
    string mergeString = "";

    for (int i = 0; i < word2.Length || i < word1.Length; i++)
    {
        if (i < word1.Length)
        {
            mergeString += word1[i];
        }
        if (i < word2.Length)
        {
            mergeString += word2[i];
        }
    }

    Console.WriteLine(mergeString);
    return "";
}

MergeAlternately2("abca", "pqrs");