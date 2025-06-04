using System;

namespace ejercicio2_modulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldo, comision, ventas, totalPagar;
            float porcentaje;

            sueldo = 15000;
            porcentaje = 0.05f;

            Console.WriteLine("Ingresa las ventas realizadas por el vendedor");
            ventas = int.Parse(Console.ReadLine());

            comision = (int)(ventas * porcentaje);

            totalPagar = comision + sueldo;

            Console.WriteLine($"La comisión para el vendedor es de ${comision}");

            Console.WriteLine($"Y el total del sueldo es de: ${totalPagar}");
        }
    }
}
