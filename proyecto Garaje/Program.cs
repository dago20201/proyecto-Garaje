using System;

namespace Garaje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE GESTIÓN DE GARAJE ===");

            
            Garaje miGaraje = new Garaje(101, "Garaje Residencial Centro", 50, 15);

           
            miGaraje.MostrarInformacion();

            Console.WriteLine("\n=== PRUEBAS DEL SISTEMA ===\n");

            
            Console.WriteLine($"Espacios disponibles iniciales: {miGaraje.EspaciosDisponibles()}\n");

           
            Console.WriteLine("--- Intentando ocupar 10 espacios ---");
            miGaraje.ActualizarEspaciosOcupados(10);
            Console.WriteLine();

          
            Console.WriteLine("--- Intentando ocupar 30 espacios ---");
            miGaraje.ActualizarEspaciosOcupados(30);
            Console.WriteLine();

            
            miGaraje.MostrarInformacion();
                 
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}