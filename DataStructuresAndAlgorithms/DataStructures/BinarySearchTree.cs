
namespace DataStructuresAndAlgorithms.DataStructures
{
    public class BinarySearchTreeNode
    {
        public int Value { get; set; }
        public BinarySearchTreeNode LeftChild { get; set; }
        public BinarySearchTreeNode RightChild { get; set; }


        public override bool Equals(object comparisonObject)
        {
            var otherNode = comparisonObject as BinarySearchTreeNode;

            if (otherNode == null)
            {
                return false;
            }

            if (this.Value == otherNode.Value && 
                ((this.RightChild == null && otherNode.RightChild == null) || (this.RightChild.Value == otherNode.RightChild.Value)) &&
                ((this.LeftChild == null && otherNode.LeftChild == null) || (this.LeftChild.Value == otherNode.LeftChild.Value)))
            {
                return true;
            }

            return false;
        }
    }


    public class BinarySearchTree
    {

        public BinarySearchTreeNode Root { get; set; }
        public int Length { get; set; }

        public BinarySearchTree()
        {
            this.Root = null;
            this.Length = 0;
        }

        //O(log n)
        public BinarySearchTreeNode Insert(int value)
        {

            BinarySearchTreeNode newNode = new BinarySearchTreeNode();
            newNode.Value = value;
            this.Length++;

            if (this.Length == 0 || this.Root == null)
            {
                this.Root = newNode;
                return this.Root;
            }

            BinarySearchTreeNode currentNode = this.Root;
            while (currentNode != null)
            {
                if (value < currentNode.Value)
                {
                    if (currentNode.LeftChild == null)
                    {
                        currentNode.LeftChild = newNode;
                        break;
                    }
                    currentNode = currentNode.LeftChild;
                }
                else
                {
                    if (currentNode.RightChild == null)
                    {
                        currentNode.RightChild = newNode;
                        break;
                    }
                    currentNode = currentNode.RightChild;
                }
            }

            return newNode;
        }

        //O(log n)
        public BinarySearchTreeNode Lookup(int searchValue)
        {
            if(this.Length == 0 || this.Root == null)
            {
                return null;
            }

            BinarySearchTreeNode currentNode = this.Root;
            
            while (currentNode != null)
            {
                if(currentNode.Value == searchValue)
                {
                    return currentNode;
                }

                if(searchValue < currentNode.Value)
                {
                    currentNode = currentNode.LeftChild;
                }
                else
                {
                    currentNode = currentNode.RightChild;
                }
            }

            return null;
        }
    }
}
