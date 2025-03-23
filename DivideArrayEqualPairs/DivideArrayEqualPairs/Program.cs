/*
Exercício: Divide Array into Equal Pairs

Nesse exercício você deve implementar a função DivideArray que recebe um array de inteiros e retorna
true se for possível dividir o array em pares de números iguais e false caso contrário.

Restrições:
nums.length == 2 * n
1 <= n <= 500
1 <= nums[i] <= 500

Exemplos de entrada:
[1,2,3,4] 

Nenhum par de números iguais foi encontrado, então a saída 
esperada para a entrada acima é: false


[3,2,3,2,2,2]

Aqui é possível dividir o array em 3 pares de números iguais:
(3,3) (2,2) (2,2)

Então, a saída esperada para a entrada acima é: true

*/


bool DivideArray(int[] nums)
{

    if (nums.Length % 2 != 0) return false;
    

    int pairs = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] == 0 || nums[j] == 0)
            {
                continue;
            }
            if (nums[i] == nums[j])
            {
                nums[i] = 0;
                nums[j] = 0;
                pairs++;
                break;
            }
        }
    }

    return (pairs == (nums.Length / 2)) ? true : false;

}

Console.WriteLine(DivideArray([3,2,3,2,2,2]));



