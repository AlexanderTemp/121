using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBetaMonopolio
{
    class SuerteoCasaComun
    {
        int id;
		string nombre;
		string descripcion;
		int aumentaodesaumenta;
		public SuerteoCasaComun(int id,string nombre, string descripcion, int aumentaodesaumenta)
		{
			this.id=id;
			this.nombre=nombre;
			this.descripcion=descripcion;
			this.aumentaodesaumenta=aumentaodesaumenta;
		}
		public string Mostrar(){
			return "Nombre de la carta: "+this.nombre+"\nDescripcion: "+this.descripcion;
		}

		public string Nombre {
			get {
				return nombre;
			}
			set {
				nombre = value;
			}
		}

		public string Descripcion {
			get {
				return descripcion;
			}
			set {
				descripcion = value;
			}
		}

		public int Aumentaodesaumenta {
			get {
				return aumentaodesaumenta;
			}
			set {
				aumentaodesaumenta = value;
			}
		}

		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}
    }
}
