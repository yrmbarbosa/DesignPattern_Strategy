using System;

namespace aplicado
{
    class Program
    {
        static void Main(string[] args)
        {

            Orcamento orcamento = new Orcamento(1000);
            
            IImposto icms = new ICMS();
            IImposto iss = new ISS();

            CalculadorDeImpostos calc = new CalculadorDeImpostos();

            Console.WriteLine(orcamento.Valor);
            Console.WriteLine(calc.CalculaImposto(orcamento, icms));
            Console.WriteLine(calc.CalculaImposto(orcamento, iss));

            Console.ReadKey();

        }
    }
}
