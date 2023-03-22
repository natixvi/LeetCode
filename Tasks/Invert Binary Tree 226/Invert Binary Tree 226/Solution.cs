﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invert_Binary_Tree_226
{
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            
            if (root == null)
            {
                return null;
            }


            /*  TreeNode temp = root.left;
              root.left = root.right;
              root.right = temp;*/
            (root.left, root.right) = (root.right, root.left);
     
            InvertTree(root.left);
            InvertTree(root.right);

            return root;
           
        }
    }
}
