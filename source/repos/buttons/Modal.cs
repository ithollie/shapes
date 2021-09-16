using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace buttons
{
    internal class Modal : ClassNode
    {
        private string name;
        private string date;
        private string picture;
        private string[,] multidiamentionArray;
       

        public Modal()
        {
            Console.WriteLine("Modal contructor is called");
            inintiateUsers();
  
        }
 
    }
}