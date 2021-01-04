using System;
using System.Data;
using System.Configuration;
using System.Web;


namespace EntidadesCompartidas
{
    /// <summary>
    /// Descripción breve de Empleado
    /// </summary>
    public abstract class Empleado
    {
        private int ci;
        private string nombre;
        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int CI
        {
            get { return ci; }
            set { ci = value; }
        }

        public Empleado()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
    }
}