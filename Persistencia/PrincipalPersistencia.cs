using System;
using System.IO;
using logica;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Persistencia
{
    public class PrincipalPersistencia
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
                if (Instance != null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        public List<Vehiculo> Vehiculos = new List<Vehiculo>();
        public bool GuardarListaVehiculos()
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Documentos\ListaVehiculos", false))
            {
                string ListaJson = JsonConvert.SerializeObject(Vehiculos);
                writer.Write(ListaJson);
                return true;
            }
        }
        public List<Vehiculo> LeerArchivoDeVehiculos()
        {
            using (StreamReader reader = new StreamReader(@"C:\ Documentos\ListaVehiculos"))
            {
                string json = reader.ReadToEnd();
                List<Vehiculo> VehiculosDesdeArchivo = JsonConvert.DeserializeObject<List<Vehiculo>>(json);
                return VehiculosDesdeArchivo;
            }
        }
    }
}





