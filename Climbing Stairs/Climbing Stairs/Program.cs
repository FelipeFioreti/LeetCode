/*

Exercício: Retornar a quantidade de caminhos dintintos que se pode subir
uma escada de n degraus, onde n é um número inteiro positivo.

Restrições:

1 <= n <= 45

Exemplo:

Entrada: 2
Saida: 2
Existem duas maneiras de subir uma escada de 2 degraus. 
Uma maneira é subir 1 degrau duas vezes. A outra maneira é subir 2 degraus de uma vez.

Entrada: 3
Saida: 3
Existem três maneiras de subir uma escada de 3 degraus. 
Uma maneira é subir 1 degrau três vezes. 
Outra maneira é subir 2 degraus de uma vez e depois subir mais 1.
A última maneira é o inverso da segunda, 1 degraus de uma vez e depois mais 2.

*/

int ClimbStairs(int n)
{
    int[] ways = new int[n + 1];

    ways[0] = 1;
    ways[1] = 1;

    for (int i = 2; i <= n; i++)
    {
        ways[i] = ways[i - 1] + ways[i - 2];
    }

    return ways[n];
}


Console.WriteLine(ClimbStairs(3));
