using DataStructuresAndAlgorithms.DataStructures;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.Algorithms
{
    public class Traversal
    {
        //For use on trees/graphs - in this example function, a binary tree from this project is passed in
        //rather than adding this method to that class itself.
        //This function returns a string diplaying the nodes visited for demo purposes, and is more of a
        //traversal than a search.

        //BFS works by fanning out from the root, visting every node on a level before going down to the
        //next level.
        //O(n) time complexity as every node must be visited.
        public string BreadthFirstSearch(BinarySearchTree bst)
        {
            if (bst == null || bst.Length == 0)
            {
                return string.Empty;
            }

            var currentNode = bst.Root;
            var output = new List<string>();
            var children = new Queue<BinarySearchTreeNode>(); //holds the children to traverse at the next level.

            children.Enqueue(currentNode);

            while (children.Count > 0)
            {
                currentNode = children.Dequeue(); //Removes and returns the item at the beginning of the queue.

                output.Add(currentNode.Value.ToString());

                if (currentNode.LeftChild != null)
                {
                    children.Enqueue(currentNode.LeftChild);
                }

                if (currentNode.RightChild != null)
                {
                    children.Enqueue(currentNode.RightChild);
                }
            }

            return string.Join(",", output);
        }

        public string BreadthFirstSearch_Recursive(Queue<BinarySearchTreeNode> children, List<string> output)
        {
            if (children == null || children.Count == 0)
            {
                return string.Join(",", output);
            }

            var currentNode = children.Dequeue(); //Removes and returns the item at the beginning of the queue.

            output.Add(currentNode.Value.ToString());

            if (currentNode.LeftChild != null)
            {
                children.Enqueue(currentNode.LeftChild);
            }

            if (currentNode.RightChild != null)
            {
                children.Enqueue(currentNode.RightChild);
            }

            return BreadthFirstSearch_Recursive(children, output);
        }
    }
}
