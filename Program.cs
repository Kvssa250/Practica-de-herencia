using System;

namespace Practica_de_Herencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una hamburguesa: ");
            Console.WriteLine("1) Clasica  2) Saludable  3) Premium");
            int seleccion = Convert.ToInt32(Console.ReadLine());


            if (seleccion == 1)
            {
                Hamburguesa hamburguesa = new Hamburguesa("", "", 0);

                Console.WriteLine("Cuantos ingredientes extra desea agregar? (maximo 4) ");
                int cantidad_ingredientes = Convert.ToInt32(Console.ReadLine());

                if (cantidad_ingredientes > 4)
                {
                    Console.WriteLine("No puede agregar mas de 4 ingredientes.");
                }
                else
                {
                    int precio_ingrediente = cantidad_ingredientes * 20;
                    Console.WriteLine("Por favor indique los ingredientes que va a querer: ");

                    for (int i = 0; i < cantidad_ingredientes; i++)
                    {
                        hamburguesa.Agregar_Ingrediente(Console.ReadLine(), precio_ingrediente);
                    }

                    hamburguesa.Mostrar_precio();
                }
            }

            if (seleccion == 2)
            {
                Saludable saludable = new Saludable("", "", 0);

                Console.WriteLine("Cuantos toppings desea agregar? (máximo 6) ");
                int cantidad_ingredientes = Convert.ToInt32(Console.ReadLine());

                if (cantidad_ingredientes > 6)
                {
                    Console.WriteLine("No puede más de 6");
                }
                else
                {
                    int precioI = cantidad_ingredientes * 20;
                    Console.WriteLine("Escriba sus toppings");

                    for (int i = 0; i < cantidad_ingredientes; i++)
                    {
                        saludable.Agregar_Ingrediente(Console.ReadLine(), precioI);
                    }
                    saludable.Mostrar_precio();
                }
            }

            if (seleccion == 3)
            {
                Premium premium = new Premium("", "", 0);
                premium.Mostrar_precio();
            }

        }
    }
}