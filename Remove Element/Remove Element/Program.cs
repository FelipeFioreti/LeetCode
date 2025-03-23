

int RemoveElement(int[] nums, int val)
{

    List<int> lista = new List<int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            lista.Add(nums[i]);
        }
    }

    for (int i = 0; i < lista.Count; i++)
    {
        nums[i] = lista[i];
    }

    return lista.Count;
}

Console.WriteLine(RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2));
