using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        
        public void Plus_Click(object sender, EventArgs e)
        {


            Form2 fm2 = new Form2();
            fm2.Show();
            fm2.Location = this.Location;
            this.Hide();

        }
    }
}
