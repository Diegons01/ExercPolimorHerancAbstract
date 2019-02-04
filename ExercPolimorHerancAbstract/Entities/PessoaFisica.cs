using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciPolimorfismoHeranca02.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastoComSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoComSaude) :base(nome, rendaAnual)
        {
            GastoComSaude = gastoComSaude;
        }

        public override double CalculoImposto()
        {
            return 0.0;
        }
    }
}
