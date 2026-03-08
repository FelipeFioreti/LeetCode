/*

Excercício: Dado um array de inteiros, remover os valores duplicados para que um valor 
apareça apenas uma vez.

Restrições:

1 <= nums.length <= 3 * 104
-100 <= nums[i] <= 100
nums é classificado em ordem não decrescente.


Exemplo:

Entrada: nums = [1,1,2]
Saída: 2, nums = [1,2,_] Não importa o valor dos elementos após a classificação.

Entrada: nums = [0,0,1,1,1,2,2,3,3,4]
Saída: 5, nums = [0,1,2,3,4,_,_,_,_,_]
                     
*/

int RemoveDuplicates(int[] nums)
{

    int count = 0;

    for (int i = 1; i < nums.Length; i++)
    {

        if (nums[i] != nums[count])
        {

            count++;
            nums[count] = nums[i];

        }
    }

    return count;
}

Console.WriteLine(RemoveDuplicates([1, 1, 2]));