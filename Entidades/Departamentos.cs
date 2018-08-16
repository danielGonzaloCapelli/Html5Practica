using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    class Departamentos
    {
        private int id = 0;
        private string Descripcion = "";
        private int idResponsable = 0;

        public int idDepartament
        {
            get { return id; }
            set { id = value; }
        }
        public string Description
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        public int Responsable
        {
            get { return idResponsable; }
            set { idResponsable = value; }
        }
    }
}
