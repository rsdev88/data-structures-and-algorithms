using DataStructuresAndAlgorithms.DataStructures;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.Algorithms
{
    public class Traversal
    {
        //For use on trees/graphs - in these example functions, a binary tree from this project is passed in
        //rather than adding these methods to that class itself.
        //These functions return a string diplaying the nodes visited for demo purposes, in the order
        //they were visited, and are more traversals rather than searches.


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

        //DFS works by starting from the root and exploring all the nodes down a certain path before coming back
        // up and repeating the process for the next path, until all nodes are visited.
        //O(n) time complexity as every node must be visited.

        //There are 3 implementations for returning the output from DFS:
        /*
                9
              /   \
             4    20
            / \  /  \
           1  6 15  170

        In order: 1, 4, 6, 9, 15, 20, 170
        Pre-order: 9, 4, 1, 6, 20, 15, 170
        Post-order: 1, 6, 4, 15, 170, 20, 9

        All three implementations still traverse the tree in the same order. The only difference
        is the order in which they print/process the nodes.
         */

        public string DepthFirstSearch_InOrder(BinarySearchTreeNode node, List<string> output)
        {
            //Keep traversing down the left path
            if (node.LeftChild != null)
            {
                DepthFirstSearch_InOrder(node.LeftChild, output);
            }

            //Add the node to the list when there's no more left paths to traverse down.
            output.Add(node.Value.ToString()); 

            //Then start looking down the right paths
            if(node.RightChild != null)
            {
                DepthFirstSearch_InOrder(node.RightChild, output);
            }

            return string.Join(",", output);
        }

        public string DepthFirstSearch_PreOrder(BinarySearchTreeNode node, List<string> output)
        {

            //Add the node to the list before traversing all the way down the left paths.
            output.Add(node.Value.ToString());

            //Keep traversing down the left path
            if (node.LeftChild != null)
            {
                DepthFirstSearch_PreOrder(node.LeftChild, output);
            }

            //Then start looking down the right paths
            if (node.RightChild != null)
            {
                DepthFirstSearch_PreOrder(node.RightChild, output);
            }

            return string.Join(",", output);
        }

        public string DepthFirstSearch_PostOrder(BinarySearchTreeNode node, List<string> output)
        {
            //Keep traversing down the left path
            if (node.LeftChild != null)
            {
                DepthFirstSearch_PostOrder(node.LeftChild, output);
            }

            //Then start looking down the right paths
            if (node.RightChild != null)
            {
                DepthFirstSearch_PostOrder(node.RightChild, output);
            }

            //Add the node to the list before traversing all the way down the left then right paths.
            output.Add(node.Value.ToString());

            return string.Join(",", output);
        }
    }
}
