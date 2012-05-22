using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DojoTJ_Episodio1
{
    class Caixa
    {
        public int QuantidadeNotasCem { get; set; }
        public int QuantidadeNotasCinquenta { get; set; }
        public int QuantidadeNotasVinte { get; set; }
        public int QuantidadeNotasDez { get; set; }

        public List<Nota> Saque(int valor)
        {
            var notasResult = new List<Nota>();



            return notasResult;
        }

        public long GuardaQuantidadeNotasRetornoResto(Nota nota, long valorSaque, int guardaQuantidade)
        {
            guardaQuantidade =(int) valorSaque / nota.Valor;
            return valorSaque = guardaQuantidade * nota.Valor;

        }

        public bool SaqueValido(int valor) 
        {
            long notas = 100;
            while (notas >= 10)
	       {
                
	         
	        }


            
            if (valor != 0 && valor >= 10)
            {
                if(valor >= 100)
                {
                    long resto = 0;
                    resto = valor % 100;
                    if(resto > 0)
                        //TODO
                    else 
                    return true;
                }
            }
                return true;
            else
                return false;
        }
    }
}
