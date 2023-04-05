using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_de_Herencia
{
    public class Premium : Hamburguesa
    {
        public Premium(string tipo_pan, string carne, int precio_base) : base(tipo_pan, carne, precio_base)
        {
            tipo_pan = "de hamburguesa";
            carne = "Angus premium";
            precio_base = 400;
        }

        public virtual void Agregar_Ingrediente()
        {
            Console.WriteLine("No se le pueden agregar ingredientes a una hamburguesa premium.");
        }

        public override void Mostrar_precio()
        {
            base.Mostrar_precio();
            Console.WriteLine($"Su hamburguesa tendra pan {tipo_pan}, carne {carne} y {ingredientes.Count} ingredientes.");
            Console.WriteLine($"El total de su compra es {precio_base}");
        }
    }
}
