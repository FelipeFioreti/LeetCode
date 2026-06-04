Console.WriteLine(NumberOfSubmatrices([['X', 'Y', '.'], ['Y', '.', '.']]));

int NumberOfSubmatrices(char[][] grid)
{
    int res = 0;
    int count = 0;
    bool hasX = false;

    for (var i = 0; i < grid.Length; i++)
    for (var j = 0; j < grid[0].Length; j++)
    {
        if (grid[i][j] == 'X')
        {
            hasX = true;
            count++;
        }
        else if (grid[i][j] == 'Y') count--;

        if (count == 0 && hasX) res++;
    }

    count = 0;
    hasX = false;
    
    for (var j = 0; j < grid[0].Length; j++)
    for (var k = 0; k < grid.Length; k++)
    {
        if (grid[k][j] == 'X')
        {
            hasX = true;
            count++;
        }
        else if (grid[k][j] == 'Y') count--;

        if (count == 0 && hasX) res++;
    }

    return res;
}