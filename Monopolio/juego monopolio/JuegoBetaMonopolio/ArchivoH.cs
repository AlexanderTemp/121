using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBetaMonopolio
{
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class ArchivoH
    {
        private string NOMBRE;
        public ArchivoH(string h)
        { this.NOMBRE = h; }
        public void crearnuevo()
        {
            if (File.Exists(NOMBRE))
                File.Delete(NOMBRE);
        }
        public void adicionar(string a, string b)
        {
            //int i = 1;
            Stream arch = File.Open(NOMBRE, FileMode.OpenOrCreate);
            BinaryWriter escribe = new BinaryWriter(arch);
            Historial hi = new Historial();
            try
            {
                    hi.lector(a);
                    hi.lector(b);
                    escribe.Seek(0, SeekOrigin.End);
                    hi.escribir(escribe);
            }
            catch (Exception)
            {
            }
            finally
            {
                arch.Close();
            }
        }
        
        public void listar()
        {
            Stream arch = File.Open(NOMBRE, FileMode.OpenOrCreate);
            BinaryReader l = new BinaryReader(arch);
            Historial hi = new Historial();
            try
            {
                while (true)
                {
                    hi.leer(l);
                    hi.Mostrar();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("fin de archivo");
            }
            finally
            {
                arch.Close();
            }

        }
    }
}
