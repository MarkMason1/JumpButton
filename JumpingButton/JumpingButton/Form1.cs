using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JumpingButton
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        
        public static extern IntPtr LoadCursorFromFile(string filename);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           /* Random rand = new Random();
            var LocationY = rand.Next(ClientSize.Height-150);
            var LocationX = rand.Next(ClientSize.Width-250);
            button1.Location = new Point(LocationX, LocationY);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
         
            var buttonX = button1.Location.X ;
            var buttonY = button1.Location.Y ;
            var mouseX = Control.MousePosition.X;
            var mouseY = Control.MousePosition.Y;

            Text = $"Button: {buttonX}, {buttonY} // Mouse: {mouseX}, {mouseY}";
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            var buttonX = button1.Location.X;
            var buttonY = button1.Location.Y;
            var mouseX = Control.MousePosition.X;
            var mouseY = Control.MousePosition.Y;

            Text = $"Button: {buttonX}, {buttonY} // Mouse: {mouseX}, {mouseY}";
            var PointM = new Point(mouseX -250, mouseY-150);
            var PointB = new Point(buttonX, buttonY);
            if (PointB.Equals(button1.Location))
            {
                var LocationY = rand.Next(ClientSize.Height - 150);
                var LocationX = rand.Next(ClientSize.Width - 250);
                button1.Location = new Point(LocationX, LocationY);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Cursor mycursor = new Cursor(Cursor.Current.Handle);
            
            IntPtr colorcursorhandle = LoadCursorFromFile(@"C:\Users\mark2\source\repos\JumpingButton\JumpingButton\bin\Debug\police.cur");
            mycursor.GetType().InvokeMember("handle", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField, null, mycursor, new object[] { colorcursorhandle });
            this.Cursor = mycursor;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
