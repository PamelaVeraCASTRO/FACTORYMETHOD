using System;
using System.Collections.Generic;
using System.Text;

namespace FACTORYMETHOD
{
    public class PizzeriaColombiana : Pizzeria
    {

        public override Pizza CPizza(string tipo)
        {
            // se implementa los diferentes tipos de condimentos 
            if (tipo == "Normal")
            {
                return new PizzaNormal("Colombiana");
            }
            else if (tipo == "Especial")
            {
                return new PizzaEspecial("Colombiana");
            }
            else if (tipo == "De la casa")
            {
                return new Pizzadelacasa("Colombiana");
            }
            else
            {
                return null;
            }
        }
    }
}
