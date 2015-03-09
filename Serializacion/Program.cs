using System;
using System.Xml.Serialization;

namespace serializar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("|   Bienvenido   |");
            Console.WriteLine("------------------");
            Console.WriteLine("|   1. Alumno    |");
            Console.WriteLine("|   2. Encagado  |");
            Console.WriteLine("------------------");
            Console.WriteLine();
            var x = Console.ReadLine();
            Console.WriteLine();

            if (x.Equals("1"))
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("|       Alumno:      |");
                Console.WriteLine("----------------------");
                Console.WriteLine("Ingresa tu carnet:");
                var carnet = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingresa tu nombre:");
                var nombre = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingresa tu apellido:");
                var apellido = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingresa tu direccion:");
                var direccion = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("encargado");
                var encargado = Console.ReadLine();
                Console.WriteLine();
                serializar seri = new serializar();
                seri.carnet = carnet;
                seri.nombre = nombre;
                seri.apellido = apellido;
                seri.direccion = direccion;
                seri.encargado = encargado;
                seri.save("Alumno.xml");
            }
            if (x.Equals("2"))
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("|     Encargado      |");
                Console.WriteLine("----------------------");
                Console.WriteLine("Ingresa tu nombre:");
                var nombre = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingresa tu apellido");
                var apellido = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingresa tu telefono");
                var telefono = Console.ReadLine();
                Console.WriteLine();
                serializar seri = new serializar();
                seri.nombre_Encargado = nombre;
                seri.Apellido_Encargado = apellido;
                seri.telefono_Encargado = telefono;
                seri.save("Encargado.xml");
            }

        }
    }
}
