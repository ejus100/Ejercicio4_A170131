using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UNACH.CALCULARAREA.CA
{
    /// <summary>
    /// Descripción breve de CalcularArea
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularArea : System.Web.Services.WebService
    {

        [WebMethod]
        public string Bienvenida()
        {
            return "Servicio Web para calcular área de cuadrado, triangulo, circulo by Eliezer Josué Urbina Sánchez 9K LSC";
        }

        [WebMethod(Description = "Método que permite calcular el área de un cuadrado")]
        public decimal Cuadrado(decimal lado1, decimal lado2)
        {
            Calcular calcula = new Calcular();
            calcula.Lado1 = lado1;
            calcula.Lado2 = lado2;
            return calcula.cuadrado();
        }

        [WebMethod(Description = "Método que permite calcular el área de un triángulo")]
        public decimal Triangulo(decimal basee, decimal altura)
        {
            Calcular calcula2 = new Calcular();
            calcula2.Basee = basee;
            calcula2.Altura = altura;
            return calcula2.triangulo();
        }

        [WebMethod(Description = "Método que permite calcular el área de un Circulo")]
        public double Circulo(double radio)
        {
            Calcular calcula3 = new Calcular();
            calcula3.Radio = radio;
            return calcula3.circulo();
        }

    }
}
