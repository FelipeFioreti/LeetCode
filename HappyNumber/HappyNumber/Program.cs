
bool isHappy(int n)
{
    int number = n;

    int count = 0;
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

        Console.WriteLine(agregate);

        if (agregate == 1)
        {
            return false;
        }

        if (numberList.Contains(agregate))
        {
            return false;
        }

        numberList.AddLast(agregate);
        number = agregate;
        agregate = 0;
    }
}

isHappy(19);
