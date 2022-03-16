using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona
    {
        //Metodos 
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String NombresCompletos { get; set; }
        public int Edad { get; set; }

        //Atributos
        public string EsMayorEdad(int edadMinima)
        {
            String mensaje = "Es Menor de Edad";
            if (Edad>18){
                mensaje = "Es Mayor de Edad";
            }
            return mensaje;
        }
        public void AsignarNombresCompletos()
        {
            NombresCompletos = string.Concat(Nombres, "", Apellidos);
        }


    }
}
