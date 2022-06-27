using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoBetaMonopolio
{
    public partial class Final : Form
    {
        public Final(string a)
        {
            InitializeComponent();
            finaltext.Text = a;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por Jugar!!!");
            this.Close();
        }
    }
}
