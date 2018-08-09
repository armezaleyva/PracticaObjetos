using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaObjetos {
    class Persona {
        // Atributos
        // Definidos a través de variables
        public string nombre;
        public string apellidos;
        public string fechaNacimiento;
        public int edad;
        public float altura;

        // Métodos
        // Definidos a través de funciones
        public void cumplirAños() {
            edad += 1;
        }

        public void crecer(float cantidadCrecimiento) {
            altura += cantidadCrecimiento;
        }

    }
}
