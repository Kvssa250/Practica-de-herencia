using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_de_Herencia
{
    public class Hamburguesa
    {
        protected string tipo_pan { get; set; }
        protected string carne { get; set; }
        protected int precio_base { get; set; }
        public List<(string ingrediente, int precio_ingrediente)> ingredientes;

        public Hamburguesa(string tipo_pan, string carne, int precio_base)
        {
            tipo_pan = "de agua";
            carne = "Angus";
            precio_base = 250;
        }

        public virtual void Agregar_Ingrediente(string ingrediente, int precio_ingrediente)
        {
            if (ingredientes.Count <= 4)
            {
                ingredientes.Add((ingrediente, precio_ingrediente));
                precio_base += precio_ingrediente;
            }
            else
            {
                Console.WriteLine("No se permiten mas ingredientes.");
            }
        }

        public virtual void Mostrar_precio()
        {
            Console.WriteLine($"Su hamburguesa tendra pan {tipo_pan}, carne {carne} y {ingredientes.Count} ingredientes.");
            Console.WriteLine($"El total de su compra es {precio_base}");
        }
    }
}
