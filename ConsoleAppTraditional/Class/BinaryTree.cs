namespace ConsoleAppTraditional.Class
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        private TreeNode<T> root;
        public BinaryTree()
        {
            root = null;
        }

        public void Insert(T value)
        {
            root = InsertRecursive(root, value);
        }

        private TreeNode<T> InsertRecursive(TreeNode<T> current, T value)
        {
            if(current == null)
            {
                return new TreeNode<T>(value);
            }

            if(value.CompareTo(current.Value) < 0)
            {
                current.Left = InsertRecursive(current.Left, value);
            }else
            {
                current.Right = InsertRecursive(current.Right, value);
            }
            return current;
        }

        public bool Search(T value)
        {
            return SearchRecursive(root, value);
        }

        private bool SearchRecursive(TreeNode<T> current, T value)
        {
            if(current == null)
            {
                return false;
            }

            if(value.CompareTo(current.Value) == 0)
            {
                return true;
            }
            else if (value.CompareTo(current.Value) < 0)
            {
                return SearchRecursive(current.Left, value);
            }
            else
            {
                return SearchRecursive(current.Right, value);
            }
        }
    }

    public class TreeNode<T>
    {
        public T Value { get; set; }

        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

}
