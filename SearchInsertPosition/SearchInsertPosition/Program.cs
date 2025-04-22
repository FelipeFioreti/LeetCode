/*
    Dado um array ordenado de inteiros e um alvo, retorne o índice se o alvo for encontrado. 
    Se não for encontrado, retorne o índice onde ele deveria estar se fosse inserido em ordem. 


    Restrições:

    1 <= nums.length <= 10^4
    -10^4 <= nums[i] <= 10^4
    nums contém valores distinstos ordenados de forma ascendetente.
    -10^4 <= target <= 10^4


    Explicação:
    O algoritmo utiliza a busca binária para encontrar o índice onde o alvo deve ser inserido.

    Exemplo:
    Entrada: nums = [1, 3, 5, 6], target = 5
    Saída: 2 // O alvo 5 já está presente no índice 2.

    Entrada: nums = [1, 3, 5, 6], target = 2
    Saída: 1 // O alvo 2 deve ser inserido no índice 1 para manter a ordem.

*/

int SearchInsert(int[] nums, int target)
{

    int menor = 0;
    int maior = nums.Length - 1;
    int meio = 0;

    while (menor <= maior)
    {
        meio = (menor + maior) / 2;

        if (nums[meio] == target)
        {
            return meio;
        }

        if (nums[meio] < target)
        {
            menor = meio + 1;
        }
        else
        {
            maior = meio - 1;
        }
    }
    return menor;
}

Console.WriteLine(SearchInsert([1, 3, 5, 6], 4));
 