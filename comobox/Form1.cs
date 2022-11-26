using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_combo.Items.AddRange(new string[] { "zero", "un", "deux", "trois", "quatre" });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txt_combo.Text.ToString() + "," + txt_combo.SelectedIndex.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_combo.Items.RemoveAt(txt_combo.SelectedIndex);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {

            txt_combo.Items.Add(txt_name.Text);
            txt_name.Text = "";
            txt_name.Focus();

        }
    }
}
