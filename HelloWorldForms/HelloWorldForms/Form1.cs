using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldForms
{
    public partial class Form1 : Form
    {
        int counter = 0; //Integer to count the clicks
        public Form1()
        {
            InitializeComponent();
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            counter++; //Increment counter (like C++)
            countBtn.Text = $"Clicks: {counter}"; //Show the text on the Button (String format)
        }
    }
}
