using System;
using System.Collections.Generic;
using System.Text;

namespace FACTORYMETHOD
{
   public  class PizzaEspecial:Pizza
    {
        public PizzaEspecial(string origen)
        {
            // describimos el origen de la pizza y añadimos una descripcion
            descripcion = " Pizza Especial";
            _origen = origen;
        }
    }
}

