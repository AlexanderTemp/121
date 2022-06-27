using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBetaMonopolio
{
    using System.IO;
    [Serializable]
    class Historial
    {
        string nom;
        public void lector(string a)
        {
            nom = a;
        }
        public void Mostrar()
        {
            Console.WriteLine("Nombre: " + this.nom);
        }
        public void escribir(BinaryWriter J)
        {   J.Write(this.nom);
        }
        public void leer(BinaryReader L)
        {
            this.nom = L.ReadString();
        }
        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }
    }
}
