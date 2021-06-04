using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bimestral_Bravo_Curipallo_Simbaña_Zamora
{
    public class Actividad
    {
        //Atributos
        private int idActividad;
        private string titulo;
        private string lugar;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private DateTime horaInicio;
        private DateTime horaFin;
        private string descripcion;
        private string tipo;
        private List<Contacto> invitados;
        private int cont = 0;
        //Constructores
        public Actividad()
        {
            
        }
       /* public Actividad(int iniIdActividad, string iniTitulo, string iniLugar, DateTime iniFechaInicio, DateTime iniFechaFin,
            DateTime iniHoraInicio, DateTime iniHoraFin, string iniDescripcion)
        {
            this.IdActividad = cont;
            this.Titulo = iniTitulo;
            this.Lugar = iniLugar;
            this.FechaInicio = iniFechaInicio;
            this.FechaFin = iniFechaFin;
            this.HoraInicio = iniHoraInicio;
            this.HoraFin = iniHoraFin;
            this.Descripcion = iniDescripcion;
        }
        public Actividad(int iniIdActividad, string iniTitulo, string iniLugar, DateTime iniFechaInicio, DateTime iniFechaFin,
            DateTime iniHoraInicio, DateTime iniHoraFin, string iniDescripcion, List<Contacto> iniInvitados,string tipo)
        {
            this.IdActividad = cont;
            this.Titulo = iniTitulo;
            this.Lugar = iniLugar;
            this.FechaInicio = iniFechaInicio;
            this.FechaFin = iniFechaFin;
            this.HoraInicio = iniHoraInicio;
            this.HoraFin = iniHoraFin;
            this.Descripcion = iniDescripcion;
            this.Invitados=iniInvitados;
            this.Tipo = tipo;
        }*/

        



        //Gets & Sets
        public int IdActividad { get => idActividad; set => idActividad = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public List<Contacto> Invitados { get => invitados; set => invitados = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {
            return this.idActividad+"."+this.titulo + ":" +this.Descripcion;
        }
    }
}
