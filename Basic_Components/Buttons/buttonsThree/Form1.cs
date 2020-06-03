using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
