using System;
using System.Collections.Generic;
using System.Text;

namespace FACTORYMETHOD
{
    public abstract class Pizza
    {
        // cada pizza posee atributos como descripcion y origen ls cuales seran usados para separarlos y enviarlos al lugar que corresponde 
        protected string descripcion;
        protected string _origen;
        // se crea un metodo que muestre por pantalla las caracteristicas de la pizza 
        public void Render()
        {
            Console.WriteLine(string.Format("Pizza {0} condimentada al estilo {1}", descripcion, _origen));
        }
      
    }
}
