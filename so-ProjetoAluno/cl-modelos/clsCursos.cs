using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_modelos
{
    public class clsCursos : clsModelo
    {
        private string cursoNome;
        private string cursoObservacao;
        private Int32 _codigoPeriodo;


        public string Curso
        {
            get { return cursoNome; }
            set { cursoNome = value; }
        }

        public string Observacao
        {
            get { return cursoObservacao; }
            set { cursoObservacao = value; }
        }

        public int CodigoPeriodo
        {
            get { return _codigoPeriodo; }
            set { _codigoPeriodo = value; }
        }

    }
}
