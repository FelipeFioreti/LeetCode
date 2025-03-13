
bool isHappy(int n)
{
    int number = n;
    int agregate = 0;

    LinkedList<int> digitsNumber = new LinkedList<int>();
    LinkedList<int> numberList = new LinkedList<int>();

    while (true)
    {
        while (number > 0)
        {
            digitsNumber.AddFirst(number % 10);
            number /= 10;
        }

        foreach (var item in digitsNumber)
        {
            agregate += item * item;
        }

        if (agregate == 1)
        {
            return true;
        }

        if (numberList.Contains(agregate))
        {
            return false;
        }

        numberList.AddLast(agregate);
        number = agregate;
        agregate = 0;
        digitsNumber.Clear();
    
    }
}

isHappy(19);
