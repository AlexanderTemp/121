using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBetaMonopolio
{
    class Propiedades
    {
        int id;
        string nombre;
        int costo;
        Boolean comprado;
        int costoCasas;
        int nMaxCasas = 1;
        int costoPaso;
        string propietario;
        public Propiedades(int id, string nombre, int costo, int costoPaso)
        {
            this.id = id;
            this.nombre = nombre;
            this.costo = costo;
            this.comprado = false;
            this.costoCasas = costo;
            this.costoPaso = costoPaso;
            this.nMaxCasas = 0;
            this.propietario = "";
        }
        public Boolean estaComprado()
        {
            if (this.comprado) return true;
            else return false;
        }
        public string Mostrar()
        {
           return "Nombre de la Propiedad: " + this.nombre+"\nCosto: " + this.costo+"\nCosto de Paso: " + this.costoPaso+"\nNumero de Casas compradas: " + this.nMaxCasas+"\nPropietario: " + this.propietario;

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

        public int Costo
        {
            get
            {
                return costo;
            }
            set
            {
                costo = value;
            }
        }

        public bool Comprado
        {
            get
            {
                return comprado;
            }
            set
            {
                comprado = value;
            }
        }

        public int CostoCasas
        {
            get
            {
                return costoCasas;
            }
            set
            {
                costoCasas = value;
            }
        }

        public int NMaxCasas
        {
            get
            {
                return nMaxCasas;
            }
            set
            {
                nMaxCasas = value;
            }
        }

        public int CostoPaso
        {
            get
            {
                return costoPaso;
            }
            set
            {
                costoPaso = value;
            }
        }

        public string Propietario
        {
            get
            {
                return propietario;
            }
            set
            {
                propietario = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
