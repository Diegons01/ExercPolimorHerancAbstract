using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercPolimorHerancAbstract.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionario { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionario) : base(nome, rendaAnual)
        {
            NumeroFuncionario = numeroFuncionario;
        }

        public override double CalculoImposto()
        {
            double totalImposto = 0.0;

            if (NumeroFuncionario <= 10)
            {
                totalImposto = RendaAnual * 0.16;
            }
            else
            {
                totalImposto = RendaAnual * 0.14;
            }
            return  totalImposto;
        }

        public override string ToString()
        {
            return Nome
                + ": $ "
                + CalculoImposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
