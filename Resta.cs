using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones_aritmeticas
{
    public class Resta: Operacion
    {
            public int operar()
            {
                Resultado = valor1 - valor2;
                return Resultado; 
            }
        }

    
}

