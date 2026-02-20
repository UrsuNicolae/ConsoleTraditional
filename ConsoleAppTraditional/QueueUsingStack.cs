namespace ConsoleAppTraditional
{
    public struct QueueUsingStack
    {
        private Stack<int> stackForAppend = new Stack<int>();
        private Stack<int> stackForStorage = new Stack<int>();

        public QueueUsingStack()
        {

        }
        public void Enqueue(int value)
        {
            stackForAppend.Push(value);
        }

        public int Dequeue()
        {
            if(stackForStorage.Count == 0)
            {
                while(stackForAppend.Count > 0)
                {
                    stackForStorage.Push(stackForAppend.Pop());
                }
            }
            return stackForStorage.Pop();
        }

        public bool IsEmpty()
        {
            return stackForStorage.Count == 0 && stackForAppend.Count == 0;
        }

        public int Peek()
        {
            if(stackForStorage.Count == 0)
            {
                while (stackForAppend.Count > 0)
                {
                    stackForStorage.Push(stackForAppend.Pop());
                }
            }
            return stackForStorage.Peek();
        }
    }
}
