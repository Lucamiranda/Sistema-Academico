using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_modelos
{
    public class clsPeriodos : clsModelo
    {

        private string periodoNome;
        public string Nome
        {
            get { return periodoNome; }
            set { periodoNome = value; }
        }


    }
}
