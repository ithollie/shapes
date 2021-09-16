using System;
using System.Security.Policy;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace buttons
{
	internal class ClassNode
	{
		public Node first;
		public string[] array;

		public int increment; 
		public ClassNode()
		{
			this.first = null;
			this.increment = -1;
			this.array = new string[6];
		}

		public void insert(string name, string date, string picture)
		{

			Node current = first;

			if (current == null)
			{
				if (increment < 6) {
					Node newNode = new Node(name, date, picture);
					first = newNode;
					increment++; 
					array[increment] = newNode.name;
					
				}
			}

			if (current != null)
			{
				
				if (increment < 6)
                {
					
					
					increment++;
					Node newNode = new Node(name, date, picture);

                    if (!newNode.name.Equals(current.name))
                    {
						newNode.nextNode = first;
						first = newNode;
						array[increment] = newNode.name;
                    }
					
                }
				
				
			}
		}

		//  display data
		public void displayUsers()
		{
			Node current = first;

			while (current != null)
			{
				MessageBox.Show("{" + "Shape name " + current.name + " date " + current.date + " picture " + current.picture);
				current = current.nextNode;
			}
		}
		//  display data
		public void displayUser(string name)
		{
			Node current = first;

			while (current != null)
			{
				if(current.name.Equals(name))
                {
					MessageBox.Show("{" + "Shape name " + current.name + " date " + current.date + " picture " + current.picture);
					
                }

				current = current.nextNode;
			}
		}
		public void displayArray()
        {
			for(int i =  0;  i < array.Length; i++)
            {
				if(array.Length > 0)
                {
					Console.WriteLine("increment is " + increment);

					Console.WriteLine("{" + "Array Shape name is" + array.GetValue(i));
	
                }
				
			}
        }
		
		public string findShapeName(string value)
		{
			if(array.Length == 0)
            {
				MessageBox.Show("array is == null");
            }
            else
            {
				MessageBox.Show("array is LEN" + array.Length);
				MessageBox.Show("first element is " + array.GetValue(0));
			}
			for(int i = 0;  i <  array.Length; i++)
            {
                if (array[i] == value)
                {
					return array[i];
                }
            }
			return "";
		}

		public void users()
		{
			Node current = first;
			int increament = 0;

			if(current != null)
            {
				System.Windows.Forms.MessageBox.Show("current is not null " + current);

			}
			while (current != null){
				array[increament] = current.name;
				current = current.nextNode;
				increament++;
				
			}

			if(current == null)
            {
				
				System.Windows.Forms.MessageBox.Show("current is " + current);
            }

	
		}
		//inserting data automatically
		public bool inintiateUsers() {
		
			insert("Circle", "10/19/1992", "c:\\pictureBox\\circle.jpg");
			insert("Rectangle", "10/19/1992", "c:\\pictureBox\\rectangle.jpg");
			insert("Triangle", "10/19/1992", "c:\\pictureBox\\triangle.jpg");
			insert("Hexagon", "10/19/1992", "c:\\pictureBox\\hexagon.jpg");
			insert("Pentagon", "10/19/1992", "c:\\pictureBox\\pentagon.jpg");
			return true;
		}
		
		
	public bool findData(string value)
        {	
			bool condition = false;
			Node current = first;
			if(current == null)
            {
				MessageBox.Show("current is == null");
            }

			while(current != null)
            {
				if (current.name.Equals(value))
                {
					condition = true;
                }
				current = current.nextNode;
            }
			return condition;
        }
		public string[] findViews()
		{
			string[] result = new string[5];
			int increment = -1;

			Node current = first;

			while (current != null)
			{
				increment++;
				result[increment] = current.name;
				current = current.nextNode;
			}
			return result;
		}
		public string findString(string value)
		{
			string condition = null;
			Node current = first;
			if (current == null)
			{
				MessageBox.Show("current is == null");
			}

			while (current != null)
			{
				if (current.name.Equals(value))
				{
					condition = current.name;
				}
				current = current.nextNode;
			}
			return condition;
		}
		public string findDate(string value)
		{
			string condition = null;
			Node current = first;
			if (current == null)
			{
				MessageBox.Show("current is == null");
			}

			while (current != null)
			{
				if (current.name.Equals(value))
				{
					condition = current.date;
				}
				current = current.nextNode;
			}
			return condition;
		}

		public string findImage(string value)
		{
			string image = null;
			Node current = first;
			if (current == null)
			{
				MessageBox.Show("current is == null");
			}

			while (current != null)
			{
				if (current.name.Equals(value))
				{
					image = current.picture;
				}
				current = current.nextNode;
			}
			return image;
		}
	}

    
}
