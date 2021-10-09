using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_modelos
{
    public class clsModelo
    {
        private int codigoID;
        private string Sigla;


        public int Codigo
        {
            get { return codigoID; }
            set { codigoID = value; }
        }

        public string Siglas
        {
            get { return Sigla; }
            set { Sigla = value; }
        }

    }
}
