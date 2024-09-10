using PathSum;

// Código para o exercício PathSum do LeetCode
// https://leetcode.com/problems/path-sum

bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null) return false;
        if (root.left == null && root.right == null && root.val == targetSum) return true;

        targetSum -= root.val;
        return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);
    }

