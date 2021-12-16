using System;
using System.Collections.Generic;
using System.Text;

namespace FACTORYMETHOD
{
    public class PizzaNormal:Pizza
    {
        public PizzaNormal(string origen)
        {
            // describimos el origen de la pizza y añadimos una descripcion
            descripcion = " Pizza Normal";
            _origen = origen;
        }
    }
}
