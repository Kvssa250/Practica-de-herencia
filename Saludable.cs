using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_de_Herencia
{
    public class Saludable : Hamburguesa
    {
        public Saludable(string tipo_pan, string carne, int precio_base) : base(tipo_pan, carne, precio_base)
        {
            tipo_pan = "Integral";
            carne = "Angus";
            precio_base = 250;
        }

        public override void Agregar_Ingrediente(string ingrediente, int precio_ingrediente)
        {
            if (ingredientes.Count < 6)
            {
                ingredientes.Add((ingrediente, precio_ingrediente));
                precio_base += precio_ingrediente;
            }
            else
            {
                Console.WriteLine("Ya no se pueden agregar mas ingredientes.");
            }
        }

        public override void Mostrar_precio()
        {
            Console.WriteLine($"Su hamburguesa tendra pan {tipo_pan}, carne {carne} y {ingredientes.Count} ingredientes.");
            Console.WriteLine($"El total de su compra es {precio_base}");
        }
    }
}
