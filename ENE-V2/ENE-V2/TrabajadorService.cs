using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENE_V2
{
    internal class TrabajadorService
    {
        private TrabajadorRepository trabajadorReposiroty = TrabajadorRepository.GetInstancia();
        public void AgregarTrabajador(Trabajador trabajador)
        {
            if (string.IsNullOrEmpty(trabajador.Rut) || string.IsNullOrEmpty(trabajador.Nombre) || string.IsNullOrEmpty(trabajador.Apellido) || string.IsNullOrEmpty(trabajador.Direccion) || string.IsNullOrEmpty(trabajador.Telefono) || string.IsNullOrEmpty(trabajador.ValorHora) || string.IsNullOrEmpty(trabajador.ValorExtra))
            {
                throw new System.ArgumentException("Todos los campos deben tener valores");
            }
            trabajadorReposiroty.GuardarTrabajador(trabajador);
        }
        public List<Trabajador> ObtenerTodosTrabajadores()
        {
            return trabajadorReposiroty.ObtenerTodosTrabajadores();
        }
        public Trabajador ObtenerTrabajadorPorRut(string ParametroRut)
        {
            return trabajadorReposiroty.ObtenerTrabajadorPorRut(ParametroRut);
        }
        public void EditarTrabajador(string rut, string nombre, string apellido, string direccion, string telefono)
        {
            trabajadorReposiroty.EditarTrabajador(rut, nombre, apellido, direccion, telefono);
        }
    }
}
