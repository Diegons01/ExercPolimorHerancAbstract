using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciPolimorfismoHeranca02.Entities
{
    class PessoaJuridica
    {
        public int NumeroFuncionario { get; set; }

        public PessoaJuridica(int numeroFuncionario)
        {
            NumeroFuncionario = numeroFuncionario;
        }
    }
}
