namespace Invert_Binary_Tree_226
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));
            Solution solution = new Solution();
            TreeNode root = solution.InvertTree(treeNode);
            //przeszukanie drzewa wszerz z wykotzystniem kolejki!
            Queue<TreeNode> q = new Queue<TreeNode>(); //queue is FIFO 
            q.Enqueue(root); //dodaje element na końcu kolejki 4
            Console.WriteLine(q);
            while (q.Count > 0)
            {
                TreeNode curr = q.Dequeue(); //	Usuwa obiekt i zwraca go na początku Queue obiektu . usuwa 4 i zapisuje w zmiennej curr
                if (curr == null) continue;
                q.Enqueue(curr.left);
                q.Enqueue(curr.right);

                Console.Write(curr.val);
            }
        }
    }
}