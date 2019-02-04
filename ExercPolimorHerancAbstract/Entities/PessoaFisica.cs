using System.Globalization;

namespace ExercPolimorHerancAbstract.Entities
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
           double totalImposto = 0.0;

            if (RendaAnual < 20000.00)
            {
                totalImposto = RendaAnual * 0.15 - GastoComSaude * 0.50;
            }
            else
            {
                totalImposto = RendaAnual * 0.25 - GastoComSaude * 0.50;
            }

            return totalImposto;
        }

        public override string ToString()
        {
            return Nome
                + ": $ "
                + CalculoImposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
