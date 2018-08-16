using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Especialidad
    {
        public int Agregar(Entidades.Especialidad espe)
        {
            int resulta = 0;
            string strSql= "Insert into Especialidad VALUES(@descripcionEspecialidad)";
           SqlConnection con = new SqlConnection(Conexion.strConexion);
            SqlCommand com = new SqlCommand( strSql,  con);

                 com.Parameters.AddWithValue("@descripcionEspecialidad", espe.EspecialityDescription);
            try
            { con.Open();
             resulta= com.ExecuteNonQuery();
            }catch(Exception excep)
            {
                throw new Exception("Error al ingresar la especialidad: " + excep.ToString());
            }
            return resulta;

        }
    }
}
