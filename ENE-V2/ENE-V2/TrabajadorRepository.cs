using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENE_V2
{
    internal class TrabajadorRepository
    {
        public static TrabajadorRepository instancia;
        private List<Trabajador> listaTrabajadores = new List<Trabajador>();
        private TrabajadorRepository() { }

        public static TrabajadorRepository GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new TrabajadorRepository();
            }
            return instancia;
        }
        public void GuardarTrabajador(Trabajador trabajador)
        {
            listaTrabajadores.Add(trabajador);
        }
        public List<Trabajador> ObtenerTodosTrabajadores()
        {
            return listaTrabajadores;
        }
        public Trabajador ObtenerTrabajadorPorRut(string ParametroRut)
        {
            return listaTrabajadores.Find(t => t.Rut == ParametroRut);
        }
        public bool EditarTrabajador(string rut, string nuevoNombre, string nuevoApellido, string nuevoDireccion, string nuevoTelefono)
        {

            Trabajador trabajdor = ObtenerTrabajadorPorRut(rut);
            if (trabajdor != null)
            {
                trabajdor.Nombre = nuevoNombre;
                trabajdor.Apellido = nuevoApellido;
                trabajdor.Direccion = nuevoDireccion;
                trabajdor.Telefono = nuevoTelefono;

                return true;
            }
            return false;
        }
    }
}
