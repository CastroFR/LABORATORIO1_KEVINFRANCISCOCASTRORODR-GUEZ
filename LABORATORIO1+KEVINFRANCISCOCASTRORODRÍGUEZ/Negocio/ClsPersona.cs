using LABORATORIO1_KEVINFRANCISCOCASTRORODRÍGUEZ.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO1_KEVINFRANCISCOCASTRORODRÍGUEZ.Negocio
{
    public class ClsPersona
    {
        public string CalcularIMC(Persona est)
        {
            double pollo = est.Peso / Math.Pow(est.Altura, 2);

            if (pollo < 24) 
            {
                return ("Peso ideal");
            
            }
            else
            {
                return ("Tiene sobrepeso");
            }

        }
        public string EsMayorDeEdad(Persona est)
        {
            if (est.Edad >= 18)
            {
                return ("Es Mayor de Edad");
            }
            else
            {
                return ("Es Menor de Edad");
            }
        }
    }
}
