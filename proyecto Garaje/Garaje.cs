using System;

namespace Garaje
{
    public class Garaje
    {
      
        private int numeroDeGaraje;
        private string descripcion;
        private int capacidadDeEspacios;
        private int espaciosOcupados;

        
        public Garaje(int numeroDeGaraje, string descripcion, int capacidadDeEspacios, int espaciosOcupados)
        {
            this.numeroDeGaraje = numeroDeGaraje;
            this.descripcion = descripcion;
            this.capacidadDeEspacios = capacidadDeEspacios;
            this.espaciosOcupados = espaciosOcupados;
        }

       
        public int EspaciosDisponibles()
        {
            return capacidadDeEspacios - espaciosOcupados;
        }

       
        public void ActualizarEspaciosOcupados(int espaciosSolicitados)
        {
            
            if (espaciosSolicitados <= EspaciosDisponibles())
            {
                espaciosOcupados += espaciosSolicitados;
                Console.WriteLine($"Se han ocupado {espaciosSolicitados} espacios.");
                Console.WriteLine($"Espacios ocupados actuales: {espaciosOcupados}");
                Console.WriteLine($"Espacios disponibles: {EspaciosDisponibles()}");
            }
            else
            {
                Console.WriteLine($"Error: Solo hay {EspaciosDisponibles()} espacios disponibles.");
                Console.WriteLine($"No se pueden asignar {espaciosSolicitados} espacios.");
            }
        }

        
        public int GetNumeroDeGaraje()
        {
            return numeroDeGaraje;
        }

        public void SetNumeroDeGaraje(int numeroDeGaraje)
        {
            this.numeroDeGaraje = numeroDeGaraje;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public void SetDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public int GetCapacidadDeEspacios()
        {
            return capacidadDeEspacios;
        }

        public void SetCapacidadDeEspacios(int capacidadDeEspacios)
        {
            this.capacidadDeEspacios = capacidadDeEspacios;
        }

        public int GetEspaciosOcupados()
        {
            return espaciosOcupados;
        }

        public void SetEspaciosOcupados(int espaciosOcupados)
        {
            this.espaciosOcupados = espaciosOcupados;
        }

        
        public void MostrarInformacion()
        {
            Console.WriteLine("=== INFORMACIÓN DEL GARAJE ===");
            Console.WriteLine($"Número de Garaje: {numeroDeGaraje}");
            Console.WriteLine($"Descripción: {descripcion}");
            Console.WriteLine($"Capacidad Total: {capacidadDeEspacios} espacios");
            Console.WriteLine($"Espacios Ocupados: {espaciosOcupados}");
            Console.WriteLine($"Espacios Disponibles: {EspaciosDisponibles()}");
            Console.WriteLine("===============================");
        }
    }
}