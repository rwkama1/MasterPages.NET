using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    public class PersistenciaJornalero
    {
        public static Empleado Logueo(int ci, string pass)
        {
            Empleado resp = null;
            SqlConnection cnn = new SqlConnection(Conexion.STR);
            SqlCommand cmd = new SqlCommand("LogueoJornalero", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", ci);
            cmd.Parameters.AddWithValue("@pass", pass);

            SqlDataReader lector;

            try
            {
                cnn.Open();
                lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    resp = new Jornalero();
                    resp.CI = (int)lector[0];
                    resp.Nombre = lector[2].ToString();
                    resp.Pass = pass;
                    ((Jornalero)resp).Horas= (int)lector[4];
                    lector.Close();
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { cnn.Close(); }
            return resp;
        }
    }
}
