
Console.WriteLine(IsValid("()[]{}"));   
bool IsValid(string s)
{

    Stack<char> pilha = new();

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(' || s[i] == '[' || s[i] == '{')
        {
            pilha!.Push(s[i]);
        }
        else
        {
            if (pilha.Count == 0)
            {
                return false;
            }

            if (pilha.Peek() == '(' && s[i] == ')')
            {
                pilha.Pop();
            }
            else if (pilha.Peek() == '[' && s[i] == ']')
            {
                pilha.Pop();
            }
            else if (pilha.Peek() == '{' && s[i] == '}')
            {
                pilha.Pop();
            }
            else
            {
                return false;
            }

        }
    }

    return pilha.Count == 0;
}