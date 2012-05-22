using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DojoTJ_Episodio1
{
    public class Nota
    {
        /// <summary>
        /// Representação da nota.
        /// </summary>
        public NotaDisponivel DescricaoNota
        {
            get;
            set;
        }


        //Valor da nota.
        public int Valor 
        {
            get
            {
                return (int)DescricaoNota; 
            }
        }
    }
}
