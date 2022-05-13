using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    class Principal
    {
      
        
    }
    public sealed class Singleton
    {
        public static List<Vehiculo> vehiculos = new List<Vehiculo>();
        private static Singleton instance = null;
        private Singleton()
        {

        }
        public static Singleton Instance
        {
            get
            {
                if (Instance!=null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        public static void RegistrarVehiculo(int codigo, int kilometros, string marca, string Modelo)
        {
            foreach (var item in vehiculos)
            {
                if (item.Codigo==codigo)
                {
                    Vehiculo nuevovehiculo = new Vehiculo();
                    nuevovehiculo.Codigo = codigo;
                    nuevovehiculo.Kilometros = kilometros;
                    nuevovehiculo.Marca = marca;
                    nuevovehiculo.Modelo = Modelo;

                }
        }
      }
        public void ActualizarKilometros(int nuevoKilometraje)
        {
            foreach (var item in vehiculos)
            {
                item.Kilometros = nuevoKilometraje;
            }
        }
    }
}
