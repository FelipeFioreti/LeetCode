int RomanToInt(string s)
{
    int value = 0;
    int sum = 0;
    char? lastChar = null;

    Dictionary<char, int> RomanCharacters = new Dictionary<char, int>
        {
        { 'I', 1 }, {'V', 5 } , {'X', 10 }, {'L', 50 } , {'C', 100 }, {'D', 500 }, {'M', 1000 }
        };

    foreach (char c in s.Reverse())
    {
        if (c == 'I' && (lastChar == 'V' || lastChar == 'X'))
        {
            value = -1;
        }
        else if ( c == 'X' && (lastChar == 'L' || lastChar == 'C'))
        {
            value = -10;
        }
        else if (c == 'C' && (lastChar == 'D' || lastChar == 'M'))
        {
            value = -100;
        }
        else
        {
            value = RomanCharacters[c];
        }

        sum += value;
        lastChar = c;
    }

    return sum;
}

RomanToInt("IV");
