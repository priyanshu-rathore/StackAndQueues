namespace StackAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            stack<int> list = new stack<int>();

            list.push(70);
            list.push(30);
            list.push(56);
            list.peek();
            list.pop();
            list.peek();
            list.display();
        }
    }
}