/*
O programa recebe duas strings de números binários e retorna a soma deles em uma string binária.s

Restrições:
1 <= a.Length, b.Length <= 10^4
a e b consistem apenas de caracteres de '0' ou '1'.
Cada string não pode conter os zeros à esquerda, exceto o próprio zero.

Exemplo:
a = "100", b = "110010"
Resultado = 110110

a = "111", b = "100"
Resultado = 1011
*/
string AddBinary(string a, string b)
{
    void AddToList(LinkedList<int> list, string number)
    {
        foreach (var c in number)
        {
            list.AddFirst(c - '0');
        }
    }

    LinkedList<int> aList = new LinkedList<int>();
    LinkedList<int> bList = new LinkedList<int>();

    AddToList(aList, a);
    AddToList(bList, b);

    if (a.Length >= b.Length)
    {
        for (int i = 0; i < a.Length - b.Length + 1; i++)
        {
            bList.AddLast(0);
        }
        aList.AddLast(0);
    }
    else
    {
        for (int i = 0; i < b.Length - a.Length + 1; i++)
        {
            aList.AddLast(0);
        }
        bList.AddLast(0);   
    }

    int[] aArray = aList.ToArray();
    int[] bArray = bList.ToArray();
    uint[] result = new uint[aArray.Length];
    uint storage = 0;

    for (int i = 0; i < aArray.Length; i++)
    {
        if (aArray[i] == 1 && bArray[i] == 1)
        {
            result[i] = storage;
            storage = 1;
        }
        else if(aArray[i] == 1 ||  bArray[i] == 1)
        {
            if(storage == 0)
            {
                result[i] = 1;
            }
            else
            {
                result[i] = 0;
                storage = 1;
            }
        }
        else
        {
            result[i] += storage;
            storage = 0;
        }
    }

    string resultString = "";
    foreach (uint c in result.Reverse())
    {
         resultString += c;
    }


    if (resultString.Substring(0,1) == "0")
    {
        return resultString.Substring(1,resultString.Length - 1);
    }

    return resultString;
}

Console.WriteLine(AddBinary("111", "100"));
