using System;
using System.Collections.Generic;
using System.Text;

namespace FACTORYMETHOD
{
    public class Pizzadelacasa:Pizza
    {
        public Pizzadelacasa(string origen)
        {
            // describimos el origen de la pizza y añadimos una descripcion
            descripcion = " Pizza de la casa";
            _origen = origen;
        }
    }
}
   