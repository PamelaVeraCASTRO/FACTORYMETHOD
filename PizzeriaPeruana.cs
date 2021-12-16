using System;
using System.Collections.Generic;
using System.Text;

namespace FACTORYMETHOD
{
    public class PizzeriaPeruana : Pizzeria
    {
        public override Pizza CPizza(string tipo)
        {
            // se implementa los diferentes tipos de condimentos 
            if (tipo == "Normal")
            {
                return new PizzaNormal("Peruana");
            }
            else if (tipo == "Especial")
            {
                return new PizzaEspecial("Peruana");
            }
            else if (tipo == "De la casa")
            {
                return new Pizzadelacasa("Peruana");
            }
            else
            {
                return null;
            }
        }
    }
}
