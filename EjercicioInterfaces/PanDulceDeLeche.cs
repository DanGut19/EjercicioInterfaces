using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioInterfaces
{
    internal class Pan_Dulce_de_Leche : Ingredientes
    {
        public void Imprimir()
        {
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Ingrediente1: {Ingrediente1}");
            Console.WriteLine($"Ingrediente2: {Ingrediente2}");
            Console.WriteLine($"Ingrediente3: {Ingrediente3}");
            Console.WriteLine($"Ingrediente4: {Ingrediente4}");
            Console.WriteLine($"Ingrediente5: {Ingrediente5}");
            Console.WriteLine($"Ingrediente5: {Ingrediente6}");
            Console.WriteLine($"Ingrediente5: {Ingrediente7}");
            Console.WriteLine($"Ingrediente5: {Ingrediente8}");
        }
    }
}
