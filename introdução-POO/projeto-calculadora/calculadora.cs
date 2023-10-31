using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_calculadora
{
    public class Calc
    {

        public float n1;
        public float n2;


        public float Soma()
        {
           return n1 + n2;
        }

        public float Sub()
        {
           return n1 - n2;
        }

        public float Divisao()
        {
           return n1 / n2;
        }

        public float Multipli()
        {
            return n1 * n2;
        }
    }
}