using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bimestral_Bravo_Curipallo_Simbaña_Zamora
{
    public class Contacto
    {
        //Atributos
        private int idContacto;
        private string nombreContacto;
        private string correo;
        private string direccion;
        private string telefono;
        //Constructores
        public Contacto()
        {
        }
        public Contacto(int iniIdContacto, string iniNombreContacto, string iniCorreo, string iniDireccion, string iniTelefono)
        {
            this.IdContacto = iniIdContacto;
            this.NombreContacto = iniNombreContacto;
            this.Correo = iniCorreo;
            this.Direccion = iniDireccion;
            this.Telefono = iniTelefono;
        }
        //Gets & Sets
        public int IdContacto { get => idContacto; set => idContacto = value; }
        public string NombreContacto { get => nombreContacto; set => nombreContacto = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public override string ToString()
        {
            return this.nombreContacto;
        }
    }
}
