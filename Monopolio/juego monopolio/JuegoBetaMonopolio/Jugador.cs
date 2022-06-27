using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBetaMonopolio
{
    class Jugador
    {
        string nombre;
        int dinero;
        int posacum;///reserva la posicion hasta que se reinicie a 0
        public Jugador(String nombre)
        {
            this.nombre = nombre;
            this.dinero = 2000;
            this.posacum = 0;
        }
        public string Mostrar()
        {
            return "Jugador: " + this.nombre+"\nTiene: " + this.dinero + " Bolivianos";
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int Dinero
        {
            get
            {
                return dinero;
            }
            set
            {
                dinero = value;
            }
        }
        public int Posacum
        {
            get
            {
                return posacum;
            }
            set
            {
                posacum = value;
            }
        }
    }
}
