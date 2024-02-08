using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal class Panqueques : Ingredientes
    {
        public string LitaUtensilios { get; set; }


        public void Imprimir()
        {
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Ingrediente1: {Ingrediente1}");
            Console.WriteLine($"Ingrediente2: {Ingrediente2}");
            Console.WriteLine($"Ingrediente3: {Ingrediente3}");
            Console.WriteLine($"Ingrediente4: {Ingrediente4}");
            Console.WriteLine($"Ingrediente5: {Ingrediente5}");
            Console.WriteLine($"LitaUtensilios: {LitaUtensilios}");
        }
    }
}
