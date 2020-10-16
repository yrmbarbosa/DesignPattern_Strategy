using System;
using System.Collections.Generic;
using System.Text;

namespace nao_aplicado
{
    public class CalculadorDeImpostos
    {
        public double CalculaImposto(Orcamento orcamento, string imposto)
        {

            // Conforme os impostos forem sendo criados ou necessitados de cálculo os ifs irão crescer, classe ficará pouco coesa
            if ("ICMS".Equals(imposto))
            {
                return orcamento.Valor * 0.1;                
            } 
            else if ("ISS".Equals(imposto))
            {
                return orcamento.Valor * 0.05;                
            }
            return 0;
                        
        }
    }
}
