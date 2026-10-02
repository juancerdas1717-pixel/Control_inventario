using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_inventario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int disponibles;
            int vender;
            int restante;

            Console.WriteLine("Ingrese la cantidad de producto disponible  en inventario: ");
            disponibles = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese la cantidad de unidades que desea vender: ");
            vender = int.Parse(Console.ReadLine());

            if(disponibles<0 || vender < 0 )
            {
                Console.WriteLine("!ERROR! Las cantidades no son validas");

            }
            else
            {
                if (vender <= disponibles)
                {
                    restante = disponibles - vender;
                    Console.WriteLine($"Venta realizada, unidades vendidas {vender}");
                    Console.WriteLine($"Unidades restantes {restante}");

                }
            else
                {
                    Console.WriteLine("La venta no puede realizarse por falta de disponibilidad");
                    Console.WriteLine($"Unidades disponibles:  {disponibles}");


                }  
                
                
            }
           
        }

        }
}

     

