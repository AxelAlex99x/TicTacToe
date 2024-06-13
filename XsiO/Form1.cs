using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XsiO
{
    public partial class Form1 : Form
    {
        bool rand = true;
        int cnt=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (rand)
                b.Text = "X";
            else b.Text = "O";
            
            rand=!rand;

            b.Enabled = false;
            cnt++;

            verificare();
        }

        private void verificare()
        {
            bool castigator=false;

            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && !a1.Enabled)
            {
                castigator = true;
            }
            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && !b1.Enabled)
            {
                castigator = true;
            }
            if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && !c1.Enabled)
            {
                castigator = true;
            }


            if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && !a1.Enabled)
            {
                castigator = true;
            }
            if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && !a2.Enabled)
            {
                castigator = true;
            }
            if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && !a3.Enabled)
            {
                castigator = true;
            }


            if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && !a1.Enabled)
            {
                castigator = true;
            }
            if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && !a3.Enabled)
            {
                castigator = true;
            }
           

            if (castigator)
            {
                String n_castigator = "";
                if (rand)
                    n_castigator = "O";
                else n_castigator = "X";
                 dezactivare_butoane();
                MessageBox.Show("Castigatorul este: " + n_castigator);
            }
            else
            {
                if(cnt==9)
                {
                    MessageBox.Show("Egalitate!");
                }
            }

        }      

        private void dezactivare_butoane()
        {
            foreach(Control c in Controls)
            {
                Button b = (Button) c;
                if(b!=button1 && b!=button2)
                b.Enabled=false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rand = true;
            cnt = 0;
            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                if (b != button1 && b != button2)
                { 
                    b.Enabled = true;
                    b.Text = "";
                }
                
            }
        }
    }
}
