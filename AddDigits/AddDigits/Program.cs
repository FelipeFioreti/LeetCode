
/*
Dado um número inteiro não negativo, adicione repetidamente todos os seus dígitos 
até que o resultado tenha apenas um dígito.

Exemplo:
Dado num = 38, o processo é como se segue: 3 + 8 = 11, 1 + 1 = 2.

Restrições:
0 <= num <= 2^31 - 1

*/

// Primeira Maneira
/*
int AddDigits(int num)
{
    if (num < 10)
    {
        return num;
    }
    else
    {
        string digits = Convert.ToString(num);
        int count = 0;

        foreach (char element in digits)
        {
            count += Convert.ToInt32(element) - '0';
        }

        return AddDigits(count);

    }

}
*/

//Segunda Maneira

/*


Para realizar dessa maneira é necessário conhecer um princípio matemático
chamado "raiz digital";
Definição: A RAIZ DIGITAL de um número é o resto obtido quando um número é dividido por 9.

Como funciona?
A raiz digital de um número pode ser calculada diretamente com a seguinte regra:

Se o número for 0, a raiz digital é 0.
Se o número não for múltiplo de 9, a raiz digital é num % 9.
Se o número for múltiplo de 9, a raiz digital é 9.

Explicação:

O problema pede para somar repetidamente todos os dígitos de um número até que o 
resultado tenha apenas um dígito. Se o resultado for um número maior que 9 some novamente.
Ex:
38: 3 + 8 = 11: 1 + 1 = 2
567: 5 + 6 + 7 = 18: 1 + 8 = 9
1024: 1 + 0 + 2 + 4 = 7

A raiz digital de um número é o resto obtido quando um número é dividido por 9.
A raiz digital de 38 é 2, a raiz digital de 567 é 9 e a raiz digital de 1024 é 7.
Seu resultado é exatamente o que precisamos para resolver o problema. 
Ex:
38 % 9 = 2 : 9 x 4 = 36 + 2 = 38
567 % 9 = 9 : 9 x 63 = 567, se é multiplo de 9 a raiz digital é 9.
1024 % 9 = 7 : 9 x 113 = 1.017 + 7 = 1024

*/
int AddDigits(int num)
{
    if (num == 0) return 0;
    return num % 9 == 0 ? 9 : num % 9;
}

Console.WriteLine(AddDigits(567)); // 9
