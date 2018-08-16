using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
   public  class Especialidad
    {
    public int Agregar(Entidades.Especialidad esp)
    {
            int resulta = 0;
            Datos.Especialidad desp = new Datos.Especialidad();
            try
            {
                resulta = desp.Agregar(esp);
            }catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios con el metodo de datos: " + ex.Message.ToString());
            }



            return resulta; 
    }
    }
}
