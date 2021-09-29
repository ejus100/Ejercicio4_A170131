using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNACH.CALCULARAREA.CA
{
    public class Calcular
    {
        #region PROPIEDADES
        //propiedades de calcular cuadrado
        public int MyProperty { get; set; }
        public decimal Lado1 { get; set; }
        public decimal Lado2 { get; set; }

        //propiedades de calcular triangulo

        public decimal Basee { get; set; }
        public decimal Altura { get; set; }

        //propiedades de calcular triangulo

        public double Radio { get; set; }

        #endregion



        #region METODOS
        //método de calcular cuadrado
        public decimal cuadrado()
        {
            return Lado1 * Lado2;
        }

        //método de calcular triangulo
        public decimal triangulo()
        {
            return (Basee * Altura) / 2;
        }

        //método de calcular circulo
        public double circulo()
        {
            return (3.1416 * (Radio * Radio));
        }


        #endregion

    }
}