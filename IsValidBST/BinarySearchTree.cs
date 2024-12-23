using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice_Coding_Questions.IsValidBST
{
    internal class TreeNode
    {
        public int? val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int? val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    internal class BinarySearchTree
    {
        private TreeNode? Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int? value)
        {
            var newNode = new TreeNode(value);

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            var currentNode = Root;
            while (true)
            {
                if (value < currentNode.val)
                {
                    //traverse left
                    if (currentNode.left == null)
                    {
                        currentNode.left = newNode;
                        return;
                    }

                    currentNode = currentNode.left;
                }
                else
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = newNode;
                        return;
                    }

                    currentNode = currentNode.right;
                }
            }
        }

        public int?[] BreadthFirstSearch()
        {
            // Current node being traversed, starting with root node
            var currentNode = Root;

            // An output list of all nodes traversed
            List<int?> output = new List<int?>();

            // A queue to remember the parent that needs to be traversed
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(currentNode);

            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                output.Add(currentNode.val);

                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }
                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }

            return output.ToArray();

        }



        public static bool IsValidBST(TreeNode root)
        {
            // start with root node as currentNode
            TreeNode currentNode = root;

            // push it to the queue
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(currentNode);

            // while queue has items
            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();

                Console.Write(currentNode.val + "  ");

                if (currentNode.left != null)
                {
                    if (currentNode.left.val < currentNode.val)
                    {
                        // Add left to the queue
                        queue.Enqueue(currentNode.left);
                    }
                    else
                    {
                        return false;
                    }
                }

                if (currentNode.right != null)
                {
                    if (currentNode.right.val > currentNode.val)
                    {
                        // Add right to the queue
                        queue.Enqueue(currentNode.right);
                    }
                    else
                    {
                        // The tree is not a valid BST
                        // return false, no need to traverse further
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
