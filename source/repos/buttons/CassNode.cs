using System;
using System.Security.Policy;

public class ClassNode
{
	public Node first;

	public ClassNode()
	{
		this.first = null;
	}

	public insert(string name, string date, string picture)
    {
		if(first == null)
        {
			Node newNode = new Node(name, date,  picture);
			first = newNode;
        }
		if(first != null)
        {
			Node newNode = new Node(name, date, picture);
			newNode.nextNode = first;
			first = newNode;
		}
    }

	public void displayUsers()
    {
		ClassNode current = first;
		while(current.nextNode != null)
        {
			Console.WriteLine(current.name);
			Console.WriteLine(curren.date);
			Console.WriteLine(current.picture);
		}
    }
}
