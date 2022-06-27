using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBetaMonopolio
{
    class Especiales
    {
        private int id;
		private string nombre;
		private int costo;
		private Boolean aumenta;//true aumenta false quita
		public Especiales(int id, string nombre, int costo, Boolean aumenta)
		{
			this.id=id;
			this.nombre=nombre;
			this.costo=costo;
			this.aumenta=aumenta;
			
		}

		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}

		public string Nombre {
			get {
				return nombre;
			}
			set {
				nombre = value;
			}
		}

		public int Costo {
			get {
				return costo;
			}
			set {
				costo = value;
			}
		}

		public bool Aumenta {
			get {
				return aumenta;
			}
			set {
				aumenta = value;
			}
		}
		public string Mostrar(){
            return "Nombre: " + this.nombre + "\nCosto: " + this.costo;
			if(aumenta==true)Console.WriteLine("Aumenta dinero");
			else Console.WriteLine("Disminuye dinero");
		}
    }
}
