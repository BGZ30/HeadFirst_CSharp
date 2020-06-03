using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace buttonsThree
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            EventHandler handler = new EventHandler(button_Click);

            red = new Button();  
            red.Text = "Red";  
            red.Location = new Point(100, 50);  
            red.Size = new Size(50, 50);  
            red.Click +=handler;  
            Controls.Add(red);  
        
            blue = new Button();  
            blue.Text = "Blue";  
            blue.Location = new Point(100, 100);  
            blue.Size = new Size(50, 50);  
            blue.Click += handler;  
            Controls.Add(blue);  
        
            green = new Button();  
            green.Text = "Green";  
            green.Location = new Point(100, 150);  
            green.Size = new Size(50, 50);  
            green.Click += handler;  
            Controls.Add(green);
        }

        #endregion
    }
}

