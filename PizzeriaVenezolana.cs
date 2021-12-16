using System;
using System.Collections.Generic;
using System.Text;

namespace FACTORYMETHOD
{
    public class PizzeriaVenezolana:Pizzeria
    {
        public override Pizza CPizza(string tipo)
        {
            // se implementa los diferentes tipos de condimentos 
            if (tipo == "Normal")
            {
                return new PizzaNormal("Venezolana");
            }
            else if (tipo== "Especial")
            {
                return new PizzaEspecial("Venezolana");
            }
            else if (tipo=="De la casa")
            {
                return new Pizzadelacasa("Venezolana");
            }else
            {
                return null;
            }
        }
    }
}
