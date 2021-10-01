using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioPropietario : IRepositorioPropietario
    {
         List<Propietario> propietario;

        public RepositorioPropietario()
        {
            propietario= new List<Propietario>()
            {
                new Propietario{Id=1,Nombre="Mateo",Apellidos="Salazar Ortiz",Telefono="3182909852",Cedula="1005450340",Direccion="calle 32e",Correo="mateo@gmail.com"},
                new Propietario{Id=2,Nombre="luis",Apellidos="benitez",Telefono="3152776846",Cedula="20229292",Direccion="calle 32e",Correo="luis@gmail.com"},
                new Propietario{Id=3,Nombre="josue",Apellidos="garcia",Telefono="3182909852",Cedula="723783272",Direccion="calle 56e",Correo="josue@gmail.com"},
                new Propietario{Id=3,Nombre="Julian",Apellidos="Avila",Telefono="3005970050",Cedula="1015409671",Direccion="calle 152",Correo="julavil127@gmail.com"}

            };
        }
        public Propietario AddPropietario(Propietario propietario)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePropietario(int idPropietario)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Propietario> GetAll()
        {
           return propietario;
        }

        public Propietario GetPropietario(int idPropietario)
        {
            throw new System.NotImplementedException();
        }

        public Propietario UpdatePropietario(Propietario propietario)
        {
            throw new System.NotImplementedException();
        }

        public Propietario UpdatePropietario(Propietario propietario, int idPropietario)
        {
            throw new System.NotImplementedException();
        }
    }
}