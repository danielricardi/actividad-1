using System;

namespace tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            char op = 's';
            int tipo;
            while (op == 's')
            {
                Console.Clear();
                Console.Write("              -----MENU-----           ");
                Console.WriteLine("\n1) EJERCICIO DE PROMEDIO DE NOTAS");
                Console.WriteLine("\n2) EJERCICIO DE PULSACIONES");
                Console.WriteLine("\n3) SALIR");

                do
                {
                    Console.WriteLine("\nSeleccione una opcion: ");
                    tipo = Int32.Parse(Console.ReadLine());
                } while ((tipo < 1) || (tipo > 4));

                switch (tipo)
                {
                    case 1:
                        Console.Clear ();
                        logica.ejercicio_1 ej1 = new logica.ejercicio_1();
                        ej1.promedio();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear ();
                        logica.ejercicio2 ej2 = new logica.ejercicio2 ();
                        ej2.pulsaciones();
                        Console.ReadKey();
                        break;
                    case 3: op = 'n';
                            break;
                }

            }


        }
    }
}
