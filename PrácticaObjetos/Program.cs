using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaObjetos {
    class Program {
        static void Main(string[] args) {
            Persona persona1 = new Persona();
            persona1.nombre = "Juan";
            persona1.apellidos = "Escutia";
            persona1.edad = 20;

            Console.WriteLine(persona1.nombre + " " + persona1.apellidos
                              + " tiene " + persona1.edad + " años.");

            persona1.cumplirAños();
            Console.WriteLine("Ahora " + persona1.nombre + " " + persona1.apellidos
                              + " tiene " + persona1.edad + " años.");

            persona1.altura = 1.5f;

            Console.WriteLine(persona1.nombre + " mide: " + persona1.altura);

            persona1.crecer(0.12f);

            Console.WriteLine(persona1.nombre + " ahora mide: " + persona1.altura);

            Console.ReadLine();
        }
    }
}
