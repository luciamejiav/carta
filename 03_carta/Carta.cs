// crear en la terminal dotnet new console
using System;

namespace _03_carta
{ //poner el mismo nombre que en el RootNamespace 
    internal class Carta
    {
        static void Main(string[] args)
        {
            string nombre, curso, localidad, fecha_inicio, fecha_fin;

            //introducimos los datos
            Console.Write("Introduce el nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Introduce el curso: ");
            curso = Console.ReadLine();

            Console.Write("Introduce la localidad: ");
            localidad = Console.ReadLine();

            Console.Write("Introduce la fecha de inicio: ");
            fecha_inicio = Console.ReadLine();

            Console.Write("Introduce la fecha de finalización: ");
            fecha_fin = Console.ReadLine();

            //guardamos e imprimimos todos los datos que hemos introducido en un solo string
            string carta = $"""
            Estimado {nombre},
            Bienvenido al curso de {curso} que se celebrará en la localidad de {localidad} 
            entre las fechas {fecha_inicio} y {fecha_fin}.Espero que el curso se desarrolle 
            según sus expectativas.Estaremos encantados de atenderle
            Atentamente, 
            La dirección.
            """;

            Console.WriteLine(carta);
        }
    }
}