using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace buttons
{
    public partial class Form1 : Form
    {
        public string[] data;

        public string currentShape;
        public bool active;
        public bool checkBox1Clicked;
        public bool checkBox2Clicked;

       
        public Form1()
        {
            //initializing nessary  function
            InitializeComponent();

            new  Modal();
 
            this.currentShape = null;
            this.active =  false;
            this.checkBox1Clicked = false;
            this.checkBox2Clicked = false;

      
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            Modal modal = new Modal();
            if (checkBox1Clicked == false)
            {
               

                if (active != false)
                {
                    //MessageBox.Show("Active Shape  is " + active);

                    if (modal.findData(currentShape) == true)
                    {
                        bool name = modal.findData(currentShape);

                        //MessageBox.Show("name checkbox and  active shape name is " + name);
                        label3.Text = currentShape;

                    }
                    else
                    {
                        //MessageBox.Show("There is a problem  with the checkbox");
                    }
                }
                else
                {


                    label5.Text = "There is no active shape";
                }
                checkBox1Clicked = true;
            }
            else
            {
                checkBox1Clicked = false;

                if (active != false)
                {
                    //MessageBox.Show("Active Shape  is " + active);

                    if (modal.findData(currentShape) == true)
                    {
                        bool name = modal.findData(currentShape);

                        //MessageBox.Show("name checkbox and  active shape name is " + name);
                        label3.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("There is a problem  with the checkbox");
                    }
                }
                else
                {


                    label5.Text = "There is no active shape";
                }
                checkBox1Clicked = false;
            }  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Circle1");
        }

        private void label7_Click(object sender, EventArgs e)

        {
            String nameShape = "Circle";
            string date = "10/19/1992";
            string picture = "circle.jpg";

            Modal modal = new Modal();
            
            Controller controller = new Controller(nameShape, date, picture);
            
            //MessageBox.Show("Conditional is == " + modal.findData(nameShape));

            if(modal.findData(nameShape) == true)
            {
               
                active = false;
                currentShape = null;

                if(active == false && currentShape  == null)
                {
                    active = true;
                    currentShape = nameShape;

                    label5.Text = "";
                    label5.Text = "Shape name " + nameShape + " " + "is active";

                    if (active == true  &&  currentShape.Equals(nameShape))
                    {

                        //MessageBox.Show("Shape name is good job" + modal.findData(nameShape));
                        //controller.changePicture("circle");
                        //modal.displayUser(nameShape);
                    }
                    
                    if (currentShape.Equals(nameShape) == false)
                    {
                        
                    }
                   

                }
                else
                {
                    Console.WriteLine("current shape condition doesn't sit right");
                }
               
            }
            else
            {
                MessageBox.Show("That  is  not a shape name" + controller.showShap());
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            String nameShape = "0";
            String date = "10/19/1992";
            String picture = "Triangle.jpg";

            Modal modal = new Modal();

            Controller controller = new Controller(nameShape, date, picture);

            if(modal.findData(nameShape) == true)
            {
                active = false;
                currentShape = null;

                if(active ==  false && currentShape == null)
                {
                    MessageBox.Show("Shape name is == " + modal.findData(nameShape));
                    controller.changePicture("Triangle");

                    active = true;
                    currentShape = nameShape;
                    label5.Text = "";
                    label5.Text = "Shape is active";
                    controller.changePicture(nameShape);
                }
                else
                {
                    Console.WriteLine("Thare is a problem  with the shape");
                }
                

            }
            else
            {
                MessageBox.Show("The shape that you clicked on doesn't exist");
            }
            //MessageBox.Show(controller.showShap() +" second triangle");
           
        }

        //triangle
        private void label9_Click(object sender, EventArgs e)
        {

            String nameShape = "Triangle";
            String date = "10/19/1992";
            String picture = "T.jpg";

            Modal  modal  =  new Modal();

            Controller controller = new Controller(nameShape, date, picture);

            if(modal.findData(nameShape) ==  true)
            {
                currentShape = null;
                active = false;

                if (currentShape == null && active  == false)
                {
                    currentShape = nameShape;
                    active = true;
                    
                    //MessageBox.Show("Name is == " + modal.findData(nameShape));
                    active = true;
                    currentShape = nameShape;
                    label5.Text = "";
                    label5.Text = "Shape name " + nameShape + " " + "is active";

                    controller.changePicture(picture);
                }
                else
                {
                    Console.WriteLine("There is a problem is the condition");
                }
                

            }
            
            
            //MessageBox.Show(controller.showShap());
        }

        //rectangle
        private void label8_Click(object sender, EventArgs e)
        {

            String nameShape = "Rectangle";
            String date = "10/19/1992";
            String picture = "boysthollie.jpg";

            Modal modal = new Modal();
            Controller controller = new Controller(nameShape, date, picture);

            if (modal.findData(nameShape) ==  true)
            {
                currentShape = null;
                active = false;

                if(currentShape ==  null && active == false)
                {
                    active = true;
                    currentShape = nameShape;
                    
                    label5.Text = "";
                    label5.Text = "Shape name " + nameShape + " " + "is active";

                    //MessageBox.Show("Name is == " + modal.findData(nameShape));
                    controller.changePicture(picture);
                   
                }
                else
                {
                    Console.WriteLine("There is a problem in  the conditional statement");
                }
                
            }
            else
            {
                MessageBox.Show("That shape that  you entered doesn't exist");
            }
            //MessageBox.Show(controller.showShap());
        }

        private void label10_Click(object sender, EventArgs e)
        {

            String nameShape = "Hexagon";
            String date = "10/19/1992";
            String picture = "Hexagon.jpg";

            Controller controller = new Controller(nameShape, date, picture);
            Modal modal = new Modal();

            if (modal.findData(nameShape) ==  true)
            {
                active = false;
                currentShape = null;

                if (currentShape != nameShape)
                {
               

                }
                if (active == false && currentShape == null)
                {
                    active = true;
                    currentShape = nameShape;

                   
                    label5.Text = "";
                    label5.Text = "Shape name " + nameShape + " " + "is active";
                    
                    if(currentShape == nameShape)
                    {
                       
                    }

                    if(currentShape != nameShape){
                      

                    }
                }
                else
                {
                    Console.WriteLine("There is a problem  in  the conditional statement");
                }

            }
            else
            {
            
            }
            //MessageBox.Show(controller.showShap());
        }

        private void label11_Click(object sender, EventArgs e)
        {

            String nameShape = "Pentagon";
            String date = "10/19/1992";
            String picture = "boysthollie.jpg";

            Controller controller = new Controller(nameShape, date, picture);
            Modal modal = new Modal();
            if (modal.findData(nameShape) == true)
            {
                active = false;
                currentShape = null;
                if (active  == false && currentShape == null) {

                    active = true;
                    currentShape = nameShape;
                   

                    label5.Text = "";
                    label5.Text = "Shape name " + nameShape + " " + "is active";
                    //MessageBox.Show("Name is == " + modal.findData(nameShape));
                    controller.changePicture(nameShape);
                }
                else
                {
                    Console.WriteLine("There is a  problem with the pentagon condition statement");
                }
            }
            //MessageBox.Show(controller.showShap());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Fill radio  button  is Clicked";

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Modal modal = new Modal();

            if (checkBox2Clicked == false)
            {

                if (active != false)
                {

                    //MessageBox.Show("Active Shape  is " + active);

                    if (modal.findData(currentShape) == true)
                    {

                        bool name = modal.findData(currentShape);
                        string date = modal.findDate(currentShape);

                        //MessageBox.Show("name checkbox and  active shape name is " + name);

                        label2.Text = date;

                    }
                    else
                    {
                        MessageBox.Show("There is a problem  with the checkbox");
                    }

                }else{


                    label5.Text = "There is no active shape";

                }
                checkBox2Clicked = true;
            }
            else
            {
                checkBox2Clicked = false;
                if (active != false)
                {

                    MessageBox.Show("Active Shape  is " + active);

                    if (modal.findData(currentShape) == true)
                    {

                        bool name = modal.findData(currentShape);
                        string date = modal.findDate(currentShape);

                        MessageBox.Show("name checkbox and  active shape name is " + name);

                        label2.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("There is a problem  with the checkbox");
                    }

                }
                else
                {


                    label5.Text = "There is no active shape";

                }
                checkBox2Clicked = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Active Shape  is " + active);    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modal modal = new Modal();

            if (active != false)
            {
                //MessageBox.Show("Active Shape  is " + active);

                if (modal.findData(currentShape) == true)
                {
                    bool name = modal.findData(currentShape);
                    string image = modal.findImage(currentShape);

                    MessageBox.Show("//save the pictureBox folder in your c drive//");
                    
                    pictureBox1.Image = Image.FromFile(image);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    //MessageBox.Show("Draw button is pressed ");

                }
                else
                {
                    MessageBox.Show("There is a problem  with the checkbox");
                }
            }
            else
            {

                label5.Text = "There is no active shape";
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modal modal = new Modal();

            if (active != false)
            {
                //MessageBox.Show("Active Shape  is " + active);

                if (modal.findData(currentShape) == true)
                {
                   
                    //MessageBox.Show("Clear button is clicked");

                    string image = "c:\\pictureBox\\oglogo.png";
                    label2.Text = "";
                    label3.Text = "";
                    label5.Text = "";
                    currentShape = null;
                    active = false;
                    pictureBox1.Image = Image.FromFile(image);

                }
                else
                {
                    MessageBox.Show("There is a problem  with the checkbox");
                }
            }
            else
            {

                label5.Text = "There is no active shape";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //listbox1 function 
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string shape;

            if (listBox1.SelectedIndex != -1){

                    shape = listBox1.SelectedItem.ToString();
                    switch (shape)
                    {
                        case "Circle":
                            circle();
                            
                            break;

                        case "Triangle":
                            triangle();
                       
                            break;

                        case "Rectangle":
                            rectangle();

                            break;

                        case "Hexagon":
                            hexagon();
                           
                            break;

                        case "Pentagon":
                        pentagon();
                            
                            break;
                    }
                }
                else
                {
                MessageBox.Show("Nothing is selected");
           }
            
        }
        public  void circle()
        {
            String nameShape = "Circle";
            string date = "10/19/1992";
            string picture = "circle.jpg";

            Modal modal = new Modal();

            Controller controller = new Controller(nameShape, date, picture);

            //MessageBox.Show("Conditional is == " + modal.findData(nameShape));

            if (modal.findData(nameShape) == true)
            {

                active = false;
                currentShape = null;

                if (active == false && currentShape == null)
                {
                    active = true;
                    currentShape = nameShape;

                    label5.Text = "";
                    label5.Text = "Shape name " + nameShape + " " + "is active";

                    if (active == true && currentShape.Equals(nameShape))
                    {
                        
                        
                    }

                    if (currentShape.Equals(nameShape) == false)
                    {
                        
                    }


                }
                else
                {
                    Console.WriteLine("current shape condition doesn't sit right");
                }

            }
            else
            {
                MessageBox.Show("That  is  not a shape name" + controller.showShap());
            }
        }

        //triangle fucntion 
        public void  triangle()
        {
            String nameShape = "Triangle";
            String date = "10/19/1992";
            String picture = "T.jpg";

            Modal modal = new Modal();

            Controller controller = new Controller(nameShape, date, picture);

            if (modal.findData(nameShape) == true)
            {
                currentShape = null;
                active = false;

                if (currentShape == null && active == false)
                {
                    currentShape = nameShape;
                    active = true;
              
                    //MessageBox.Show("Name is == " + modal.findData(nameShape));
                    active = true;
                    currentShape = nameShape;
                    label5.Text = "";
                    label5.Text = "Shape name " + nameShape + " " + "is active";

                    controller.changePicture(picture);
                }
                else
                {
                    Console.WriteLine("There is a problem is the condition");
                }


            }


            //MessageBox.Show(controller.showShap());
        }


        //rectangle function 
        private void rectangle()
        {

            String nameShape = "Rectangle";
            String date = "10/19/1992";
            String picture = "boysthollie.jpg";

            Modal modal = new Modal();
            Controller controller = new Controller(nameShape, date, picture);

            if (modal.findData(nameShape) == true)
            {
                currentShape = null;
                active = false;

                if (currentShape == null && active == false)
                {
                    active = true;
                    currentShape = nameShape;
                    
                    label5.Text = "";
                    label5.Text = "Shape name " + nameShape + " " + "is active";

                    //MessageBox.Show("Name is == " + modal.findData(nameShape));
                    controller.changePicture(picture);

                }
                else
                {
                    Console.WriteLine("There is a problem in  the conditional statement");
                }

            }
            else
            {
                MessageBox.Show("That shape that  you entered doesn't exist");
            }
            //MessageBox.Show(controller.showShap());
        }

        //hexagon  function 
        private void hexagon()
        {

            String nameShape = "Hexagon";
            String date = "10/19/1992";
            String picture = "Hexagon.jpg";

            Controller controller = new Controller(nameShape, date, picture);
            Modal modal = new Modal();

            if (modal.findData(nameShape) == true)
            {
                active = false;
                currentShape = null;

                if (currentShape != nameShape)
                {
                    

                }
                if (active == false && currentShape == null)
                {
                    active = true;
                    currentShape = nameShape;


                    label5.Text = "";
                    label5.Text = "Shape name " + nameShape + " " + "is active";

                    if (currentShape == nameShape)
                    {
                      
                    }

                    if (currentShape != nameShape)
                    {
                    

                    }
                }
                else
                {
                    Console.WriteLine("There is a problem  in  the conditional statement");
                }

            }
            else
            {
     
            }
            //MessageBox.Show(controller.showShap());
        }
        private void pentagon()
        {

            String nameShape = "Pentagon";
            String date = "10/19/1992";
            String picture = "boysthollie.jpg";

            Controller controller = new Controller(nameShape, date, picture);
            Modal modal = new Modal();
            if (modal.findData(nameShape) == true)
            {
                active = false;
                currentShape = null;
                if (active == false && currentShape == null)
                {

                    active = true;
                    currentShape = nameShape;
                   
                    label5.Text = "";
                    label5.Text = "Shape name " + nameShape + " " + "is active";
                    //MessageBox.Show("Name is == " + modal.findData(nameShape));
                    controller.changePicture(nameShape);
                }
                else
                {
                    Console.WriteLine("There is a  problem with the pentagon condition statement");
                }
            }
            //MessageBox.Show(controller.showShap());
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "OutLine radio  button  is Clicked";
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
        //end
    }

}
