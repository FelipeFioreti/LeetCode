
using Same_Tree;



Console.WriteLine(IsSameTree());

bool IsSameTree(TreeNode p, TreeNode q)
{

    if (p != null && q != null)
    {
        if (p.val == q.val)
        {
            if (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }

}
