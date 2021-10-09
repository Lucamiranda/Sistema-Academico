using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_modelos
{
    public class clsDisciplinas : clsModelo
    {
        private string nomeDisciplina;
        private string DisciplinaObservacao;

        public string Observacao
        {
            get { return DisciplinaObservacao; }
            set { DisciplinaObservacao = value; }
        }
        public string Disciplinas
        {
            get { return nomeDisciplina; }
            set { nomeDisciplina = value; }
        }
    }
}
