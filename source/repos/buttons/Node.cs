using System;

namespace buttons
{
    internal class Node
    {
        public string name;
        public string date;
        public string picture;
        public Node nextNode;

        //Node constructor
        public Node(string name, string date, string picture)
        {
            this.name = name;
            this.date = date;
            this.picture = picture;
            this.nextNode = null;

        }
        public void printName()
        {
            Console.WriteLine("Node name is " + name);
        }
    }
}