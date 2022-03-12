using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea.logica
{
    internal class ejercicio2
    {
        public void pulsaciones()
        {
            char sexo;
            int edad,pulsaciones;

            Console.Write("Ingrese el sexo: ");
            sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la edad: ");
            edad = Int32.Parse(Console.ReadLine());

            if(sexo == 'f')
            {
                pulsaciones = (220 - edad) / 10;
                Console.WriteLine(" las pulsaciones de mujer es: " + pulsaciones);
            }
            else
            {
                pulsaciones = (210 - edad) / 10;
                Console.WriteLine("Las pulsaciones del hombre es: " + pulsaciones);
            }
        }
    }
}
