using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea.logica
{
     class ejercicio_1
    {
        public void promedio()
        {
            int n, n2, n3;
            int suma, promedio;

            Console.Write("----------Ingrese Notas-----------");
            Console.Write("\nNota 1: "); n = Int32.Parse(Console.ReadLine());
            Console.Write("\nNota 2: "); n2 = Int32.Parse(Console.ReadLine());
            Console.Write("\nNota 3:");  n3 = Int32.Parse(Console.ReadLine());

            suma= n+n2 + n3;
            promedio = suma / 3;

            if (promedio >= 30)
            {
                Console.Write("\nEl estudiante gano la materia en "+ promedio);
            }
            else
            {
                Console.Write("\nEl estudiante perdio la materia en: " + promedio);
            }
        }
    }
}
