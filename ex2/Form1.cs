using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text == "")
            {
                MessageBox.Show("saisie un nom ... ", "Verification de la saisie ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            txt_area.Text = txt_area.Text + txt_nom.Text +"\r\n";
            txt_nom.Text = "";
            txt_nom.Focus();

        }

        private void bnt_quiter_Click(object sender, EventArgs e)
        {
            

            DialogResult res = MessageBox.Show(" Vous voulez vraiment quiter ?", " quitter", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
              this.Close();
            }
          
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form fm = new Form2();
            fm.Show();
        }

        private void txt_area_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue");
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
