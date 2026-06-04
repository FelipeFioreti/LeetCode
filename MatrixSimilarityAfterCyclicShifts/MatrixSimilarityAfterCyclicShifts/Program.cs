Console.WriteLine(AreSimilar([[1,2,1,2],[5,5,5,5],[6,3,6,3]],2));

bool AreSimilar(int[][] mat, int k)
{
    int m = mat.Length;
    int n = mat[0].Length;
    k %= n;

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            if (mat[i][j] != mat[i][(j + k) % n]) {
                return false;
            }
        }
    }
    return true;
}