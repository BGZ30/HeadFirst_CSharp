
//In Pograms.cs
//*************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*---------------------------------------------------------------*/

//In Form1.cs
//***********
namespace buttonsThree
{
    public partial class Form1 : Form
    {
        private Button red;  
        private Button blue;  
        private Button green; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e) {  
            if (sender == red) 
                this.BackColor = Color.Red ;  
            else if (sender == blue) 
                this.BackColor = Color.Blue;  
            else 
                this.BackColor = Color.Green;  
        }

    }
}

/*---------------------------------------------------------------*/

// In Form1.Designer.cs
//*********************
/* insde InitializeComponent() */

EventHandler handler = new EventHandler(button_Click);

red = new Button();  
red.Text = "Red";  
red.Location = new Point(100, 50);  
red.Size = new Size(50, 50);  
red.Click +=handler;  
Controls.Add(red);  
