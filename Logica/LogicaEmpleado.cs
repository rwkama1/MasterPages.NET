using System;
using System.Collections.Generic;
using System.Text;

using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    public class LogicaEmpleado
    {
        public static Empleado Logueo(int ci, string pass)
        {
            Empleado resp = null;

            resp = PersistenciaAsalariado.Logueo(ci, pass);

            if (resp == null)
            {
                resp = PersistenciaJornalero.Logueo(ci, pass);
            }






            return resp;
        }
    }
}
