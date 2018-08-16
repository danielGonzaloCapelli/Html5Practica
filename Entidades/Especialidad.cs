using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Especialidad
    {
        private int idEspecialidad = 0;
        private string Description = "";
        public int id
        {
            get { return idEspecialidad; }
            set { idEspecialidad = value; }

        }
        public string EspecialityDescription
        {
            get { return Description; }
            set { Description = value; }
        }
    }
}
