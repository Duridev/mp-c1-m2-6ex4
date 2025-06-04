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
            porcentaje = 0.05;

            Console.WriteLine("Ingresa las ventas realizadas por el vendedor");
            ventas = int.Parse(Console.ReadLine());

            comision = int.Parse(ventas * porcentaje);

            totalPagar = int.Parse(comision + sueldo);
        }
    }
}
