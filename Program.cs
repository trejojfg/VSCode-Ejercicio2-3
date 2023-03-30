using System;

namespace Ejercicio2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
            // Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
            
            float km, v;
            float t;
            Console.WriteLine("Introducir la distancia en km");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Indica la velocidad media");
            v = float.Parse(Console.ReadLine());
            t = km / v;
            Console.WriteLine("El tiempo que tardas es de " + t.ToString("0.00") + "horas.");

        }
    }
}
