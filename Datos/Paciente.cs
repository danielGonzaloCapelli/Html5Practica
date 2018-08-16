using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Paciente
    {
        int idPaciente { get; set; }
        int DiagnosticoIngreso { get ; set ; }
        DateTime FIngresoAtencion { get; set; }
        public Paciente() { }

    }
}
