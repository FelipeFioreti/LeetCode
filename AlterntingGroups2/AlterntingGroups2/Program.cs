/*
    O exercício consiste em implementar um programa que leia um array colors contendo 0s e 1s 
    e um inteiro k. O objetico é buscar no array quantas sequências alternadas de 0s e 
    1s existem, o tamanho dessas sequências são determinadas pelo valor de k. 

    Por exemplo:
    colors = [1, 0, 1, 0, 1, 0, 1]
    k = 5
    
    Nesse caso, existem 3 sequências alternadas de 0s e 1s de tamanho 5.

    Sequência 1: colors = [1, 0, 1, 0, 1, 0, 1]
                           1  2  3  4  5 

    Sequência 2: colors = [1, 0, 1, 0, 1, 0, 1]
                              1  2  3  4  5      

    Sequência 3: colors = [1, 0, 1, 0, 1, 0, 1]
                                 1  2  3  4  5    
    
    Restrições:
    3 <= colors.length <= 10^5
    0 <= colors[i] <= 1
    3 <= k <= colors.length
 */

int NumberOfAlternatingGroups(int[] colors, int k)
{
    int count = 1;
    int result = 0;

    int lastColor = colors[0];
    for (int i = 1; i < colors.Length; i++)
    {

        if (colors[i] == lastColor)
        {
            count = 1;
            lastColor = colors[i];
            continue;
        }

        count++;

        if (count >= k) result++;

        lastColor = colors[i];
    }

    for (int i = 0; i < k - 1; i++)
    {
        if (colors[i] == lastColor) break;

        count++;

        if (count >= k) result++;

        lastColor = colors[i];
    }

    return result;
}

Console.WriteLine(NumberOfAlternatingGroups([0, 1, 0, 1, 0, 1], 5));

