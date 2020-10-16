using System;

namespace nao_aplicado
{
    class Program
    {
        static void Main(string[] args)
        {

            Orcamento orcamento = new Orcamento(1000);

            CalculadorDeImpostos calc = new CalculadorDeImpostos();

            Console.WriteLine(orcamento.Valor);
            Console.WriteLine(calc.CalculaImposto(orcamento, "ICMS"));
            Console.WriteLine(calc.CalculaImposto(orcamento, "ISS"));

            Console.ReadKey();

        }
    }
}
