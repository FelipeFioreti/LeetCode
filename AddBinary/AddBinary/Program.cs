string AddBinary(string a, string b)
{
    int[] freq = new int[a.Length + b.Length];
    char[] aArray = a.ToCharArray();
    char[] bArray = b.ToCharArray();
    
    if (a.Length >= b.Length)
    {
        for (int i = a.Length; i >= 0; i--)
        {
            freq[i] = aArray[i];
        }
    }
    else
    {

    }



    var teste = 0b1;
    return a;
}

Console.WriteLine(AddBinary("111","111"));
