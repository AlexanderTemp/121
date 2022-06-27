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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /////////Boton de Jugar
            Menu2 ventanaJuego = new Menu2();
            ventanaJuego.Show();
            this.Hide();////////Llamar luego
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Juego desarrollado en C#\nCreado por:\nAlexander Humberto Nina Pacajes\nGuillermo Laura Mamani");
        }

    }
}
