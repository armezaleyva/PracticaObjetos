using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaObjetos {
    class Program {
        static void Main(string[] args) {
            Contacto contacto1 = new Contacto();

            contacto1.Nombre = "Pedro Lopez";
            contacto1.TelefonoCasa = "(644) 115 - 2514";
            contacto1.Direccion = "Guerrero 456";

            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Teléfono de casa:  " + contacto1.TelefonoCasa);

            Contacto contacto2 = new Contacto("Juan Perez");

            Console.WriteLine("Contacto 2");
            Console.WriteLine("Nombre: " + contacto2.Nombre);

            Contacto contacto3 = new Contacto("Maria Navarro", "1234567890",
                                              "9876543210", "5 de febrero 895",
                                              "maria@correo.com");

            Console.WriteLine("Contacto 3");
            Console.WriteLine("Nombre: " + contacto3.Nombre);
            Console.WriteLine("Celular:  " + contacto3.TelefonoCelular);
            Console.WriteLine("Teléfono de casa:  " + contacto3.TelefonoCasa);
            Console.WriteLine("Direccion: " + contacto3.Direccion);
            Console.WriteLine("Correp: " + contacto3.CorreoElectronico);

            Console.ReadKey();
        }
    }
}
