/*

Exercício: Dado um inteiro x returne true se o número é um palindromo e false se ele não for.

Número Palíndromo:
É um número inteiro que é espelhado, em que o começo e o final são iguais.
Exemplos: 121 | 1551


Restrições
-2^31 <= x <= 2^31 - 1

Exemplo:
121 retorna true
123 retorna false

*/

bool IsPalindrome(int x)
{

    string number = x.ToString();

    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] != number[number.Length - i - 1])
        {
            return false;
        }
    }

    return true;

}

Console.WriteLine(IsPalindrome(121));