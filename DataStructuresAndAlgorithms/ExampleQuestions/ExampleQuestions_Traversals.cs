using DataStructuresAndAlgorithms.DataStructures;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.ExampleQuestions
{
    public class ExampleQuestions_Traversals
    {
        // A common interview question - validate that a binary tree is valid
        // (i.e. right child is higher than parent, left child is lower than parent)
        // Can be solved using BFS.
        public bool ValidateBinaryTree(BinarySearchTree bst)
        {
            if (bst == null)
            {
                return false;
            }

            var children = new Queue<BinarySearchTreeNode>();
            var currentNode = bst.Root;

            children.Enqueue(currentNode);

            while (children.Count > 0)
            {
                currentNode = children.Dequeue();

                if (currentNode.LeftChild != null)
                {
                    if (currentNode.LeftChild.Value < currentNode.Value)
                    {
                        children.Enqueue(currentNode.LeftChild);
                    }
                    else
                    {
                        return false;
                    }
                }

                if (currentNode.RightChild != null)
                {
                    if (currentNode.RightChild.Value > currentNode.Value)
                    {
                        children.Enqueue(currentNode.RightChild);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
