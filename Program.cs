namespace StackAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            queue<int> list = new queue<int>();

            list.enqueue(56);
            list.enqueue(30);
            list.enqueue(70);
            list.dequeue();
            list.display();
        }
    }
}