using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;//dibujar el cambio de la imagen
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoBetaMonopolio
{
    public partial class Juego : Form
    {
        Jugador[] jugadores = new Jugador[2];
        Especiales[] especiales = new Especiales[6];
        Propiedades[] propiedades = new Propiedades[28];
        SuerteoCasaComun[] tarjetas = new SuerteoCasaComun[6];
        private int turno;
        private int su;
        private int suma;
        private int suma1;
        public int Turno
        {
            get
            {
                return turno;
            }
            set
            {
                turno = value;
            }
        }
        public Juego()
        {
            InitializeComponent();
            suma = 0;
            suma1 = 0;

        }
        public Juego(string j1, string j2)
        {
            InitializeComponent();
            jugadores[0] = new Jugador(j1);
            jugadores[1] = new Jugador(j2);
            this.turno = 0;////1 y 0 1 jugador 2 - 0 jugador uno
            especiales[0] = new Especiales(0, "Go", 200, true);
            especiales[1] = new Especiales(10, "Visita Carcel", 0, true);
            especiales[2] = new Especiales(20, "Parada Libre", 0, true);
            especiales[3] = new Especiales(30, "Carcel", 100, false);
            especiales[4] = new Especiales(4, "Matricula", 200, false);
            especiales[5] = new Especiales(38, "Impuestos", 100, false);
            propiedades[0] = new Propiedades(1, "Avenida Mediterranea", 60, 27); propiedades[1] = new Propiedades(3, "Avenida Baltica", 60, 28); propiedades[2] = new Propiedades(5, "ferrocarril reading", 200, 100);
            propiedades[3] = new Propiedades(6, "Avenida Oriental", 100, 45); propiedades[4] = new Propiedades(8, "Avenida Vermount", 100, 45); propiedades[5] = new Propiedades(9, "Avenida Conecticut", 120, 65);
            propiedades[6] = new Propiedades(11, "San Carlos", 140, 72); propiedades[7] = new Propiedades(12, "Compañia Electrica", 150, 80); propiedades[8] = new Propiedades(13, "Avenida de los Estados", 140, 72);
            propiedades[9] = new Propiedades(14, "Avenida Virginia", 160, 80); propiedades[10] = new Propiedades(15, "Ferrocarril Pensilvania", 200, 100); propiedades[11] = new Propiedades(16, "Paseo Saint James", 180, 95);
            propiedades[12] = new Propiedades(18, "Avenida Tenesee", 180, 95); propiedades[13] = new Propiedades(19, "Avenida Nueva York", 200, 100); propiedades[14] = new Propiedades(21, "Avenida Kentuky", 220, 110);
            propiedades[15] = new Propiedades(23, "Avenida Indiana", 220, 110); propiedades[16] = new Propiedades(24, "Avenida Illinois", 240, 120); propiedades[17] = new Propiedades(25, "Ferrocarril ByO", 200, 100);
            propiedades[18] = new Propiedades(26, "Avenida Atlantica", 260, 130); propiedades[19] = new Propiedades(27, "Avenida Ventura", 260, 130); propiedades[20] = new Propiedades(28, "Compañia de Agua", 150, 110);
            propiedades[21] = new Propiedades(29, "Jardines Marvin", 280, 140); propiedades[22] = new Propiedades(31, "Avenida del Pacifico", 300, 150); propiedades[23] = new Propiedades(32, "Carolina del Norte", 300, 150);
            propiedades[24] = new Propiedades(34, "Avenida Pensylvania", 320, 180); propiedades[25] = new Propiedades(35, "Short Line", 200, 100); propiedades[26] = new Propiedades(37, "Plaza del Parque", 350, 200);
            propiedades[27] = new Propiedades(39, "Paseo Maritimo", 400, 300);
            tarjetas[0] = new SuerteoCasaComun(2, "Concurso de Belleza", "Ganas 100 por participar en un concurso de belleza", 100);
            tarjetas[1] = new SuerteoCasaComun(7, "Fondos", "Fundacion noble necesita Fondos", -100);
            tarjetas[2] = new SuerteoCasaComun(17, "Error", "El banco a cometido un error ganas 100", 100);
            tarjetas[3] = new SuerteoCasaComun(22, "Evasion", "Se dieron cuenta de tu fraude fiscal pagas 200", -200);
            tarjetas[4] = new SuerteoCasaComun(33, "Educacion", "Se debe velar por la educacion de los niños pague 150", -150);
            tarjetas[5] = new SuerteoCasaComun(36, "Concurso de Belleza", "Ganas 100 por participar en un concurso de belleza", 100);
        }
        public void verPos(int i)
        {
            if (this.jugadores[i].Posacum > 39) this.jugadores[i].Posacum -= 40;
        }
        private void bucle_Tick(object sender, EventArgs e)
        {
        }
        private void Tablero_Click(object sender, EventArgs e)
        {
            /////tablero
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por Jugar!!!");
            Application.Exit();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            int dado, dado2;
            Random aleatoreo = new Random();
            dado = aleatoreo.Next(1, 7);
            dado2 = aleatoreo.Next(1, 7);
            if (dado == 1) { picdado1.Image = Image.FromFile("cara1.png"); }
            if (dado == 2) { picdado1.Image = Image.FromFile("cara2.png"); }
            if (dado == 3) { picdado1.Image = Image.FromFile("cara3.png"); }
            if (dado == 4) { picdado1.Image = Image.FromFile("cara4.png"); }
            if (dado == 5) { picdado1.Image = Image.FromFile("cara5.png"); }
            if (dado == 6) { picdado1.Image = Image.FromFile("cara6.png"); }
            if (dado2 == 1) { picdado2.Image = Image.FromFile("cara1.png"); }
            if (dado2 == 2) { picdado2.Image = Image.FromFile("cara2.png"); }
            if (dado2 == 3) { picdado2.Image = Image.FromFile("cara3.png"); }
            if (dado2 == 4) { picdado2.Image = Image.FromFile("cara4.png"); }
            if (dado2 == 5) { picdado2.Image = Image.FromFile("cara5.png"); }
            if (dado2 == 6) { picdado2.Image = Image.FromFile("cara6.png"); }

            if (turno == 0)
            {
                suma = suma + (dado2 + dado);
                int suma2 = dado2 + dado;
                su = dado2 + dado;
                MessageBox.Show("sacaste : " + suma2.ToString());
                pocicion_jugador1(suma, turno);
            }
            else if (turno == 1)
            {
                suma1 = suma1 + (dado2 + dado);
                int suma2 = dado2 + dado;
                su = dado + dado2;
                MessageBox.Show("sacaste : " + suma2.ToString());
                pocicion_jugador2(suma1, turno);
            }
            jug1.Text = jugadores[0].Nombre;
            jug2.Text = jugadores[1].Nombre;
            din1.Text = jugadores[0].Dinero.ToString();
            din2.Text = jugadores[1].Dinero.ToString();
            ///////////////////JUGADOR1////////////////////////////////////777
            if (this.jugadores[0].Dinero > 0 && this.jugadores[1].Dinero > 0)
            {
                if (this.turno == 0)
                {

                    this.jugadores[0].Posacum += su; this.verPos(0); bla.Text = this.jugadores[0].Mostrar();
                    if (jugadores[0].Posacum == 2 || jugadores[0].Posacum == 7 || jugadores[0].Posacum == 17
                            || jugadores[0].Posacum == 22 || jugadores[0].Posacum == 33 || jugadores[0].Posacum == 36)
                    {
                        for (int i = 0; i < this.tarjetas.Length; i++)
                        {
                            if (this.tarjetas[i].Id.Equals(jugadores[0].Posacum))
                            {
                                la.Text = this.tarjetas[i].Mostrar();
                                this.jugadores[0].Dinero += this.tarjetas[i].Aumentaodesaumenta;
                            }
                        }
                    }
                    if (jugadores[0].Posacum == 0 || jugadores[0].Posacum == 10 || jugadores[0].Posacum == 20 || jugadores[0].Posacum == 30 || jugadores[0].Posacum == 4 || jugadores[0].Posacum == 38)
                    {
                        for (int i = 0; i < especiales.Length; i++)
                        {
                            if (this.especiales[i].Id.Equals(jugadores[0].Posacum))
                            {
                                la.Text = this.especiales[i].Mostrar();
                                if (this.especiales[i].Aumenta)
                                {
                                    this.jugadores[0].Dinero += this.especiales[i].Costo;
                                }
                                else if (this.especiales[i].Aumenta == false)
                                {
                                    this.jugadores[0].Dinero -= this.especiales[i].Costo;
                                }
                            }

                        }
                    }
                    else
                    {
                        for (int i = 0; i < this.propiedades.Length; i++)
                        {
                            if (this.propiedades[i].Id.Equals(this.jugadores[0].Posacum))
                            {
                                la.Text = this.propiedades[i].Mostrar();
                                if (this.propiedades[i].Propietario != null)
                                {
                                    if (this.propiedades[i].Propietario == this.jugadores[0].Nombre) this.jugadores[1].Dinero -= this.propiedades[i].CostoPaso;
                                    else if (this.propiedades[i].Propietario == this.jugadores[1].Nombre) { this.jugadores[0].Dinero -= this.propiedades[i].CostoPaso; this.jugadores[1].Dinero += this.propiedades[i].CostoPaso; }
                                }

                            }
                        }
                    }
                    pos1.Text = this.jugadores[0].Posacum.ToString();/////PRUEBAAAAAA
                    this.Turno = 1;
                }
                ////////////////////////////JUGADOR 2//////////////////////////////////
                else
                    if (this.Turno == 1)
                    {



                        jugadores[1].Posacum += su; this.verPos(1); bla.Text = this.jugadores[1].Mostrar();
                        if (jugadores[1].Posacum == 2 || jugadores[1].Posacum == 7 || jugadores[1].Posacum == 17
                                    || jugadores[1].Posacum == 22 || jugadores[1].Posacum == 33 || jugadores[1].Posacum == 36)
                        {
                            for (int i = 0; i < this.tarjetas.Length; i++)
                            {
                                if (this.tarjetas[i].Id.Equals(jugadores[0].Posacum))
                                {
                                    la.Text = this.tarjetas[i].Mostrar();
                                    this.jugadores[1].Dinero += this.tarjetas[i].Aumentaodesaumenta;
                                }
                            }
                        }
                        if (jugadores[1].Posacum == 0 || jugadores[1].Posacum == 10 || jugadores[1].Posacum == 20 || jugadores[1].Posacum == 30 || jugadores[1].Posacum == 4 || jugadores[1].Posacum == 38)
                        {
                            for (int i = 0; i < especiales.Length; i++)
                            {
                                if (this.especiales[i].Id.Equals(jugadores[0].Posacum))
                                {
                                    if (this.especiales[i].Aumenta)
                                    {
                                        this.jugadores[1].Dinero += this.especiales[i].Costo;
                                    }
                                    else if (this.especiales[i].Aumenta == false)
                                    {
                                        this.jugadores[1].Dinero -= this.especiales[i].Costo;
                                    }
                                    la.Text = this.especiales[i].Mostrar();
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < this.propiedades.Length; i++)
                            {
                                if (this.propiedades[i].Id.Equals(this.jugadores[1].Posacum))
                                {
                                    la.Text = this.propiedades[i].Mostrar();

                                    if (this.propiedades[i].Propietario != null)
                                    {
                                        if (this.propiedades[i].Propietario == this.jugadores[0].Nombre) { this.jugadores[1].Dinero -= this.propiedades[i].CostoPaso; this.jugadores[0].Dinero += this.propiedades[i].CostoPaso; }
                                    }

                                }
                            }
                        }
                        pos2.Text = this.jugadores[1].Posacum.ToString();/////////Pruebaaaaaa


                        this.Turno = 0;
                    }
            }
            else FinDeJuego();
            ///////////////////////////////////////////////////////////////////////////////////////// ////////////////
        }
        public void pocicion_jugador1(int cont, int turno)
        {
            if (turno == 0)
            {

                picture1.Visible = false;

                picture3.Visible = false;

                picture5.Visible = false;

                picture7.Visible = false;

                picture9.Visible = false;

                picture11.Visible = false;

                picture13.Visible = false;

                picture15.Visible = false;

                picture17.Visible = false;

                picture19.Visible = false;

                picture21.Visible = false;

                picture23.Visible = false;

                picture25.Visible = false;

                picture27.Visible = false;

                picture29.Visible = false;

                picture31.Visible = false;

                picture33.Visible = false;

                picture35.Visible = false;

                picture37.Visible = false;

                picture39.Visible = false;

                picture41.Visible = false;

                picture43.Visible = false;

                picture45.Visible = false;

                picture47.Visible = false;

                picture49.Visible = false;

                picture51.Visible = false;

                picture53.Visible = false;

                picture55.Visible = false;

                picture57.Visible = false;

                picture59.Visible = false;

                picture61.Visible = false;

                picture63.Visible = false;

                picture65.Visible = false;

                picture67.Visible = false;

                picture69.Visible = false;

                picture71.Visible = false;

                picture73.Visible = false;

                picture75.Visible = false;

                picture77.Visible = false;

                picture79.Visible = false;


                Juego f3 = new Juego();
                if (cont > 40)
                {
                    cont = cont - 40;
                    suma -= 40;
                }

                switch (cont)
                {
                    case 0:
                        picture1.Visible = true;
                        picture1.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 1:
                        picture3.Visible = true;
                        picture1.Visible = false;
                        picture3.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 2:
                        picture5.Visible = true;
                        picture3.Visible = false;
                        picture5.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 3:
                        picture7.Visible = true;
                        picture5.Visible = false;
                        picture7.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 4:
                        picture9.Visible = true;
                        picture7.Visible = false;
                        picture9.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 5:
                        picture11.Visible = true;
                        picture9.Visible = false;
                        picture11.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 6:
                        picture13.Visible = true;
                        picture11.Visible = false;
                        picture13.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 7:
                        picture15.Visible = true;
                        picture13.Visible = false;
                        picture15.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 8:
                        picture17.Visible = true;
                        picture15.Visible = false;
                        picture17.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 9:
                        picture19.Visible = true;
                        picture17.Visible = false;
                        picture19.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 10:
                        picture21.Visible = true;
                        picture19.Visible = false;
                        picture21.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 11:
                        picture23.Visible = true;
                        picture21.Visible = false;
                        picture23.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 12:
                        picture25.Visible = true;
                        picture23.Visible = false;
                        picture25.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 13:
                        picture27.Visible = true; picture25.Visible = false;
                        picture27.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 14:
                        picture29.Visible = true;
                        picture27.Visible = false;
                        picture29.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 15:
                        picture31.Visible = true; picture29.Visible = false;
                        picture31.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 16:
                        picture33.Visible = true; picture31.Visible = false;
                        picture33.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 17:
                        picture35.Visible = true; picture33.Visible = false;
                        picture35.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 18:
                        picture37.Visible = true; picture35.Visible = false;
                        picture37.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 19:
                        picture39.Visible = true; picture37.Visible = false;
                        picture39.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 20:
                        picture41.Visible = true; picture39.Visible = false;
                        picture41.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 21:
                        picture43.Visible = true; picture41.Visible = false;
                        picture43.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 22:
                        picture45.Visible = true; picture43.Visible = false;
                        picture45.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 23:
                        picture47.Visible = true; picture45.Visible = false;
                        picture47.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 24:
                        picture49.Visible = true; picture47.Visible = false;
                        picture49.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 25:
                        picture51.Visible = true; picture49.Visible = false;
                        picture51.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 26:
                        picture53.Visible = true; picture51.Visible = false;
                        picture53.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 27:
                        picture55.Visible = true; picture53.Visible = false;
                        picture55.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 28:
                        picture57.Visible = true; picture55.Visible = false;
                        picture57.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 29:
                        picture59.Visible = true; picture57.Visible = false;
                        picture59.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 30:
                        picture61.Visible = true; picture59.Visible = false;
                        picture61.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 31:
                        picture63.Visible = true; picture61.Visible = false;
                        picture63.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 32:
                        picture65.Visible = true; picture63.Visible = false;
                        picture65.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 33:
                        picture67.Visible = true; picture65.Visible = false;
                        picture67.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 34:
                        picture69.Visible = true; picture67.Visible = false;
                        picture69.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 35:
                        picture71.Visible = true; picture69.Visible = false;
                        picture71.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 36:
                        picture73.Visible = true; picture71.Visible = false;
                        picture73.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 37:
                        picture75.Visible = true; picture73.Visible = false;
                        picture75.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 38:
                        picture77.Visible = true; picture75.Visible = false;
                        picture77.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;
                    case 39:
                        picture79.Visible = true; picture77.Visible = false;
                        picture79.Image = JuegoBetaMonopolio.Properties.Resources.Jug1;
                        break;

                }
            }
        }
        public void pocicion_jugador2(int cont, int turno)
        {
            if (turno == 1)
            {


                picture2.Visible = false;
                picture4.Visible = false;

                picture6.Visible = false;

                picture8.Visible = false;

                picture10.Visible = false;

                picture12.Visible = false;

                picture14.Visible = false;

                picture16.Visible = false;

                picture18.Visible = false;

                picture20.Visible = false;

                picture22.Visible = false;

                picture24.Visible = false;

                picture26.Visible = false;

                picture28.Visible = false;

                picture30.Visible = false;

                picture32.Visible = false;

                picture34.Visible = false;

                picture36.Visible = false;

                picture38.Visible = false;

                picture40.Visible = false;

                picture42.Visible = false;

                picture44.Visible = false;

                picture46.Visible = false;

                picture48.Visible = false;

                picture50.Visible = false;

                picture52.Visible = false;

                picture54.Visible = false;

                picture56.Visible = false;

                picture58.Visible = false;

                picture60.Visible = false;

                picture62.Visible = false;

                picture64.Visible = false;

                picture66.Visible = false;

                picture68.Visible = false;

                picture70.Visible = false;

                picture72.Visible = false;

                picture74.Visible = false;

                picture76.Visible = false;

                picture78.Visible = false;

                picture80.Visible = false;

                Juego f3 = new Juego();
                if (cont > 40)
                {
                    cont = cont - 40;
                    suma -= 40;
                }


                switch (cont)
                {
                    case 0:
                        picture2.Visible = true;
                        picture2.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 1:
                        picture4.Visible = true;
                        picture4.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 2:
                        picture6.Visible = true;
                        picture6.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 3:
                        picture8.Visible = true;
                        picture8.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 4:
                        picture10.Visible = true;
                        picture10.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 5:
                        picture12.Visible = true;
                        picture12.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 6:
                        picture14.Visible = true;
                        picture14.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 7:
                        picture16.Visible = true;
                        picture16.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 8:
                        picture18.Visible = true;
                        picture18.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 9:
                        picture20.Visible = true;
                        picture20.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 10:
                        picture22.Visible = true;
                        picture22.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 11:
                        picture24.Visible = true;
                        picture24.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 12:
                        picture26.Visible = true;
                        picture26.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 13:
                        picture28.Visible = true;
                        picture28.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 14:
                        picture30.Visible = true;
                        picture30.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 15:
                        picture32.Visible = true;
                        picture32.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 16:
                        picture34.Visible = true;
                        picture34.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 17:
                        picture36.Visible = true;
                        picture36.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 18:
                        picture38.Visible = true;
                        picture38.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 19:
                        picture40.Visible = true;
                        picture40.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 20:
                        picture42.Visible = true;
                        picture42.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 21:
                        picture44.Visible = true;
                        picture44.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 22:
                        picture46.Visible = true;
                        picture46.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 23:
                        picture48.Visible = true;
                        picture48.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 24:
                        picture50.Visible = true;
                        picture50.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 25:
                        picture52.Visible = true;
                        picture52.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 26:
                        picture54.Visible = true;
                        picture54.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 27:
                        picture56.Visible = true;
                        picture56.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 28:
                        picture58.Visible = true;
                        picture58.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 29:
                        picture60.Visible = true;
                        picture60.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 30:
                        picture62.Visible = true;
                        picture62.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 31:
                        picture64.Visible = true;
                        picture64.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 32:
                        picture66.Visible = true;
                        picture66.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 33:
                        picture68.Visible = true;
                        picture68.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 34:
                        picture70.Visible = true;
                        picture70.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 35:
                        picture72.Visible = true;
                        picture72.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 36:
                        picture74.Visible = true;
                        picture74.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 37:
                        picture76.Visible = true;
                        picture76.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 38:
                        picture78.Visible = true;
                        picture78.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;
                    case 39:
                        picture80.Visible = true;
                        picture80.Image = JuegoBetaMonopolio.Properties.Resources.jug2;
                        break;

                }
            }
        }
        public void FinDeJuego()
        {
            string a = "";
            if (this.jugadores[0].Dinero > 0) a = jugadores[0].Nombre;
            else if (this.jugadores[1].Dinero > 0) a = jugadores[1].Nombre;
            Final f = new Final(a);
            f.Show();
            this.Close();
        }
        private void propiedad1_Click(object sender, EventArgs e)
        {
            if (this.propiedades[0].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 1)
                {
                    this.jugadores[0].Dinero -= 60;
                    this.propiedades[0].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[0].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 1)
                {
                    this.jugadores[1].Dinero -= 60;
                    this.propiedades[0].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[0].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad2_Click(object sender, EventArgs e)
        {
            if (this.propiedades[1].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 3)
                {
                    this.jugadores[0].Dinero -= 60;
                    this.propiedades[1].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[1].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 3)
                {
                    this.jugadores[1].Dinero -= 60;
                    this.propiedades[1].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[1].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else
            {
                MessageBox.Show("Esta propiedad ya esta comprada");
            }

        }
        private void tren1_Click(object sender, EventArgs e)
        {
            if (this.propiedades[2].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 5)
                {
                    this.jugadores[0].Dinero -= 200;
                    this.propiedades[2].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[2].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 5)
                {
                    this.jugadores[1].Dinero -= 200;
                    this.propiedades[2].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[2].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad3_Click(object sender, EventArgs e)
        {
            if (this.propiedades[3].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 6)
                {
                    this.jugadores[0].Dinero -= 100;
                    this.propiedades[3].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[3].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 6)
                {
                    this.jugadores[1].Dinero -= 100;
                    this.propiedades[3].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[3].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad4_Click(object sender, EventArgs e)
        {
            if (this.propiedades[4].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 8)
                {
                    this.jugadores[0].Dinero -= 100;
                    this.propiedades[4].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[4].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 8)
                {
                    this.jugadores[1].Dinero -= 100;
                    this.propiedades[4].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[4].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad5_Click(object sender, EventArgs e)
        {
            if (this.propiedades[5].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 9)
                {
                    this.jugadores[0].Dinero -= 120;
                    this.propiedades[5].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[5].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 9)
                {
                    this.jugadores[1].Dinero -= 120;
                    this.propiedades[5].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[5].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad6_Click(object sender, EventArgs e)
        {
            if (this.propiedades[6].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 11)
                {
                    this.jugadores[0].Dinero -= 140;
                    this.propiedades[6].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[6].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 11)
                {
                    this.jugadores[1].Dinero -= 140;
                    this.propiedades[6].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[6].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void compelec_Click(object sender, EventArgs e)
        {
            if (this.propiedades[7].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 12)
                {
                    this.jugadores[0].Dinero -= 150;
                    this.propiedades[7].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[7].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 12)
                {
                    this.jugadores[1].Dinero -= 150;
                    this.propiedades[7].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[7].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad7_Click(object sender, EventArgs e)
        {
            if (this.propiedades[8].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 13)
                {
                    this.jugadores[0].Dinero -= 140;
                    this.propiedades[8].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[8].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 13)
                {
                    this.jugadores[1].Dinero -= 140;
                    this.propiedades[8].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[8].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad8_Click(object sender, EventArgs e)
        {
            if (this.propiedades[9].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 14)
                {
                    this.jugadores[0].Dinero -= 160;
                    this.propiedades[9].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[9].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 14)
                {
                    this.jugadores[1].Dinero -= 160;
                    this.propiedades[9].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[9].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void tren2_Click(object sender, EventArgs e)
        {
            if (this.propiedades[10].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 15)
                {
                    this.jugadores[0].Dinero -= 200;
                    this.propiedades[10].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[10].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 15)
                {
                    this.jugadores[1].Dinero -= 200;
                    this.propiedades[10].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[10].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad9_Click(object sender, EventArgs e)
        {
            if (this.propiedades[11].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 16)
                {
                    this.jugadores[0].Dinero -= 180;
                    this.propiedades[11].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[11].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 16)
                {
                    this.jugadores[1].Dinero -= 180;
                    this.propiedades[11].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[11].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad10_Click(object sender, EventArgs e)
        {
            if (this.propiedades[12].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 18)
                {
                    this.jugadores[0].Dinero -= 180;
                    this.propiedades[12].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[12].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 18)
                {
                    this.jugadores[1].Dinero -= 180;
                    this.propiedades[12].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[12].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad11_Click(object sender, EventArgs e)
        {
            if (this.propiedades[13].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 19)
                {
                    this.jugadores[0].Dinero -= 200;
                    this.propiedades[13].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[13].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 19)
                {
                    this.jugadores[1].Dinero -= 200;
                    this.propiedades[13].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[13].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad12_Click(object sender, EventArgs e)
        {
            if (this.propiedades[14].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 21)
                {
                    this.jugadores[0].Dinero -= 220;
                    this.propiedades[14].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[14].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 21)
                {
                    this.jugadores[1].Dinero -= 220;
                    this.propiedades[14].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[14].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad13_Click(object sender, EventArgs e)
        {
            if (this.propiedades[15].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 23)
                {
                    this.jugadores[0].Dinero -= 220;
                    this.propiedades[15].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[15].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 23)
                {
                    this.jugadores[1].Dinero -= 220;
                    this.propiedades[15].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[15].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad14_Click(object sender, EventArgs e)
        {
            if (this.propiedades[16].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 24)
                {
                    this.jugadores[0].Dinero -= 240;
                    this.propiedades[16].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[16].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 24)
                {
                    this.jugadores[1].Dinero -= 240;
                    this.propiedades[16].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[16].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void tren3_Click(object sender, EventArgs e)
        {
            if (this.propiedades[17].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 25)
                {
                    this.jugadores[0].Dinero -= 200;
                    this.propiedades[17].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[17].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 25)
                {
                    this.jugadores[1].Dinero -= 200;
                    this.propiedades[17].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[17].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad15_Click(object sender, EventArgs e)
        {
            if (this.propiedades[18].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 26)
                {
                    this.jugadores[0].Dinero -= 260;
                    this.propiedades[18].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[18].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 26)
                {
                    this.jugadores[1].Dinero -= 260;
                    this.propiedades[18].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[18].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad16_Click(object sender, EventArgs e)
        {
            if (this.propiedades[19].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 27)
                {
                    this.jugadores[0].Dinero -= 260;
                    this.propiedades[19].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[19].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 27)
                {
                    this.jugadores[1].Dinero -= 260;
                    this.propiedades[19].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[19].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void compagua_Click(object sender, EventArgs e)
        {
            if (this.propiedades[20].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 28)
                {
                    this.jugadores[0].Dinero -= 150;
                    this.propiedades[20].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[20].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 28)
                {
                    this.jugadores[1].Dinero -= 150;
                    this.propiedades[20].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[20].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad17_Click(object sender, EventArgs e)
        {
            if (this.propiedades[21].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 29)
                {
                    this.jugadores[0].Dinero -= 280;
                    this.propiedades[21].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[21].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 29)
                {
                    this.jugadores[1].Dinero -= 280;
                    this.propiedades[21].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[21].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad18_Click(object sender, EventArgs e)
        {
            if (this.propiedades[22].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 31)
                {
                    this.jugadores[0].Dinero -= 300;
                    this.propiedades[22].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[22].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 31)
                {
                    this.jugadores[1].Dinero -= 300;
                    this.propiedades[22].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[22].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad19_Click(object sender, EventArgs e)
        {
            if (this.propiedades[23].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 32)
                {
                    this.jugadores[0].Dinero -= 300;
                    this.propiedades[23].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[23].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 32)
                {
                    this.jugadores[1].Dinero -= 300;
                    this.propiedades[23].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[23].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad20_Click(object sender, EventArgs e)
        {
            if (this.propiedades[24].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 34)
                {
                    this.jugadores[0].Dinero -= 320;
                    this.propiedades[24].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[24].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 34)
                {
                    this.jugadores[1].Dinero -= 320;
                    this.propiedades[24].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[24].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void tren4_Click(object sender, EventArgs e)
        {
            if (this.propiedades[25].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 35)
                {
                    this.jugadores[0].Dinero -= 200;
                    this.propiedades[25].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[25].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 35)
                {
                    this.jugadores[1].Dinero -= 200;
                    this.propiedades[25].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[25].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad21_Click(object sender, EventArgs e)
        {
            if (this.propiedades[26].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 37)
                {
                    this.jugadores[0].Dinero -= 350;
                    this.propiedades[26].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[26].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 37)
                {
                    this.jugadores[1].Dinero -= 350;
                    this.propiedades[26].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[26].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
        private void propiedad22_Click(object sender, EventArgs e)
        {
            if (this.propiedades[27].Propietario == "")
            {
                if (this.jugadores[0].Posacum == 39)
                {
                    this.jugadores[0].Dinero -= 400;
                    this.propiedades[27].Propietario = this.jugadores[0].Nombre;
                    din1.Text = this.jugadores[0].Dinero.ToString();
                    la.Text = this.propiedades[27].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
                if (this.jugadores[1].Posacum == 39)
                {
                    this.jugadores[1].Dinero -= 400;
                    this.propiedades[27].Propietario = this.jugadores[1].Nombre;
                    din2.Text = this.jugadores[1].Dinero.ToString();
                    la.Text = this.propiedades[27].Mostrar();
                    MessageBox.Show("Compra Realizada!!!");
                }
            }
            else MessageBox.Show("Esta propiedad ya esta comprada");
        }
    }
}