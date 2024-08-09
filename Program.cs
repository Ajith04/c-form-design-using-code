using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.ExceptionServices;

namespace SimpleCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //1. creating GUI using c# code
           //2. create a console application in .net framework
           //3. insert references - 1. System.Windows.Forms, 2. System.Drawing
           //4. write using command for system.windows.forms and system.drawing
           //5. configure application.visualstyles, application.setcompatibletextrendering, application.run unsing our form's class name.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new calcForm());
        }
    }
    //creating class calcForm and inherit from Form class
    public class calcForm : Form
    {
        //creating variables for form components
        private TextBox textboxno1;
        private TextBox textboxno2;
        private Button buttontotal;


        //constructor
        public calcForm() 
        {
            //setting up form
            this.Text = "Simple Addition";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(800, 500);


            //assigning related component classes to created variables
            textboxno1 = new TextBox();
            textboxno2 = new TextBox();
            buttontotal = new Button();

            //setting location and size for form components
            textboxno1.Location = new System.Drawing.Point(50, 50);
            textboxno1.Size = new System.Drawing.Size(100, 30);

            textboxno2.Location = new System.Drawing.Point(200, 50);
            textboxno2.Size = new System.Drawing.Size(100, 30);

            buttontotal.Location = new System.Drawing.Point(120, 100);
            buttontotal.Size = new System.Drawing.Size(100, 30);
            //adding caption text to this button
            buttontotal.Text = "Find total";

            //adding onclick event for this button
            buttontotal.Click += new EventHandler(add);


            //adding created components to form
            this.Controls.Add(textboxno1);
            this.Controls.Add(textboxno2);
            this.Controls.Add(buttontotal);
            
        }

        private void add(Object sender, EventArgs e)
        {
            try
            {
                int no1 = int.Parse(textboxno1.Text);
                int no2 = int.Parse(textboxno2.Text);
                int total = no1 + no2;
                MessageBox.Show($"The total is {total}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid numbers");
            }
        }

        

    }
}
