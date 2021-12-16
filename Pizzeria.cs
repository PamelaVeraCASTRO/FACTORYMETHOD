using System;
using System.Collections.Generic;
using System.Text;

namespace FACTORYMETHOD
{
    public abstract class Pizzeria
    {
        //Creamos el metod CPizza y lo definimos como string
        public abstract Pizza CPizza(string tipo);
    }
}
