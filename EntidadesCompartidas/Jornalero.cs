using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace EntidadesCompartidas
{
    /// <summary>
    /// Descripción breve de Jornalero
    /// </summary>
    public class Jornalero : Empleado
    {
        private int horas;

        public int Horas
        {
            get { return horas; }
            set { horas = value; }
        }

        public Jornalero()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
    }
}