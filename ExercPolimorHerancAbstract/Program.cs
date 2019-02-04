using System;
using System.Globalization;
using System.Collections.Generic;
using ExercPolimorHerancAbstract.Entities;

namespace ExercPolimorHerancAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char FisicaOuJuridica = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Anual income: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (FisicaOuJuridica == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoas.Add(new PessoaFisica(nome, rendaAnual, gastoSaude));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numeroFuncionario = int.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaJuridica(nome, rendaAnual, numeroFuncionario));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double saldoTotal = 0.0;

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
                saldoTotal += pessoa.CalculoImposto();
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " + saldoTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
