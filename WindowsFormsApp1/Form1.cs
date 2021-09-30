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
        
        public void Plus_Click(object sender, EventArgs e) //open addition form
        {


            Form2 fm2 = new Form2();
            fm2.Show();
            fm2.Location = this.Location;
            this.Hide();

        }

        private void subtraction_Click(object sender, EventArgs e) //open subtraction form
        {
            Form2 fm3 = new Form2();
            fm3.Show();
            fm3.Location = this.Location;
            this.Hide();
        }

        private void times_Click(object sender, EventArgs e) //open Multiple form
        {
            Form2 fm4 = new Form2();
            fm4.Show();
            fm4.Location = this.Location;
            this.Hide();

        }

        private void division_Click(object sender, EventArgs e) //open divide form
        {
            Form2 fm5 = new Form2();
            fm5.Show();
            fm5.Location = this.Location;
            this.Hide();

        }
    }
}
