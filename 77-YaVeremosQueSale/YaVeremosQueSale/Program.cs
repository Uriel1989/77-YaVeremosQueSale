using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YaVeremosQueSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 30;

            Console.ForegroundColor = ConsoleColor.Green;

            List<Personas> Listregistros = new List<Personas>();

            Console.WriteLine("Ingrese el 's' para iniciar la carga de datos:");

            string accesos = Console.ReadLine();

            while (accesos == "s")
            {
                Personas sujeto = new Personas();

                Console.WriteLine("Ingrese el nombre de la persona:");

                sujeto.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido de la persona:");

                sujeto.Apellido = Console.ReadLine();

                Console.WriteLine("ingrese el DNI:");

                sujeto.DNI = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la nacionalidad:");

                sujeto.Nacionalidad = Console.ReadLine();

                Console.WriteLine("Ingrese el alias de internet mas usado por el sujeto:");

                sujeto.Alias = Console.ReadLine();

                Console.WriteLine("Ingrese la red social de preferencia del sujeto en cuestion:");

                sujeto.RedSocial = Console.ReadLine();

                Listregistros.Add(sujeto);

                Console.WriteLine("Si desea ingresar mas personas ingrese 's', caso contrario 'n' para finalizar:");

                accesos = Console.ReadLine();

                Console.Clear();
            }

            for ( int i= 0; i< Listregistros.Count; i++)
            {
                Personas muestra = Listregistros[i];

                Console.CursorLeft = 30;
                Console.WriteLine("Datos ingresados:");

                Console.WriteLine("Nombre:" + " " + muestra.Nombre);

                Console.WriteLine("Apellido:" + " " + muestra.Apellido);

                Console.WriteLine("DNI:" + " " + muestra.DNI);

                Console.WriteLine("Nacionalidad:" + " " + muestra.Nacionalidad);

                Console.WriteLine("Red Social de preferencia:" + " " + muestra.RedSocial);

                Console.WriteLine("Alias principal en Internet:" + " " + muestra.Alias);
            }

            Console.ReadKey();

        }
    }
}
