using System;
using System.Data;
using System.Configuration;
using System.Web;



namespace EntidadesCompartidas
{
    /// <summary>
    /// Descripción breve de Asalariado
    /// </summary>
    public class Asalariado : Empleado
    {
        private double sueldo;

        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public Asalariado()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
    }
}