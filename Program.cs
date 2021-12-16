using System;

namespace FACTORYMETHOD
{
    class Program
    {
        static void Main(string[] args)
        {
            // se observan las dos clases abstractas
            Pizzeria pizzeria;
            Pizza pizza;
            // se hace la pregutna del tipo de pizza que va a pedir 
            pizzeria = new PizzeriaColombiana();
            // se crea la pizza y se le da un condimento distinto 
            pizza = pizzeria.CPizza("Normal");
            pizza.Render();
            pizza = pizzeria.CPizza("Especial");
            pizza.Render();
            pizza = pizzeria.CPizza("De la casa");
            pizza.Render();
            // se hace la pregutna del tipo de pizza que va a pedir 
            pizzeria = new PizzeriaVenezolana();
            // se crea la pizza y se le da un condimento distinto 
            pizza = pizzeria.CPizza("Normal");
            pizza.Render();
            pizza = pizzeria.CPizza("Especial");
            pizza.Render();
            pizza = pizzeria.CPizza("De la casa");
            pizza.Render();
            // se hace la pregutna del tipo de pizza que va a pedir 
            pizzeria = new PizzeriaPeruana();
            // se crea la pizza y se le da un condimento distinto 
            pizza = pizzeria.CPizza("Normal");
            pizza.Render();
            pizza = pizzeria.CPizza("Especial");
            pizza.Render();
            pizza = pizzeria.CPizza("De la casa");
            pizza.Render();

        }
    }
}
