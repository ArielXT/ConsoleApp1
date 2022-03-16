using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            int edad = 20;
            string nombre = "Ariel";
            float sueldo = 8500;
            DateTime hoy = DateTime.Now;

            //Console.WriteLine(edad);
            //Console.WriteLine(nombre);
            //Console.WriteLine(sueldo);
            //Console.WriteLine(hoy);

            //Declaracion de objetos

            Persona persona = new Persona();
            persona.Nombres = "Ariel";
            persona.Apellidos = " Zarate";
            persona.Edad = 20;

            Persona persona1 = new Persona
            {
                Nombres = "Ariana",
                Apellidos = " Avila",
                Edad = 8,
            };

            List<Persona> personas = new List<Persona>();
            personas.Add(persona);
            personas.Add(persona1);
            foreach (var item in personas)
            {
                string mensaje = item.EsMayorEdad(18);
                item.AsignarNombresCompletos();
                Console.WriteLine(mensaje);
                Console.WriteLine(item.NombresCompletos);
            }

            Console.Read();
        }
    }
}
