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
            propietario = new List<Propietario>()
            {
                new Propietario{Id=1,Nombre="Mateo",Apellidos="Salazar Ortiz",Telefono="3182909852",Cedula="1005450340",Direccion="calle 32e",Correo="mateo@gmail.com"},
                new Propietario{Id=2,Nombre="luis",Apellidos="benitez",Telefono="3152776846",Cedula="20229292",Direccion="calle 32e",Correo="luis@gmail.com"},
                new Propietario{Id=3,Nombre="Josue",Apellidos="Morales",Telefono="3182909852",Cedula="723783272",Direccion="calle 56e",Correo="josuemorales@gmail.com"},
                new Propietario{Id=4,Nombre="Julian",Apellidos="Avila",Telefono="3005970050",Cedula="1015409671",Direccion="calle 152",Correo="julavil127@gmail.com"},
                new Propietario{Id=5,Nombre="luis",Apellidos="benitez",Telefono="3152776846",Cedula="20229292",Direccion="calle 32e",Correo="luis@gmail.com"}

            };
        }
        public Propietario AddPropietario(Propietario propietarios)
        {
           propietarios.Id=propietario.Max(r => r.Id)+1;
           propietario.Add(propietarios);
           return propietarios;
        }

        public void DeletePropietario(int idPropietario)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Propietario> GetAll()
        {
            return propietario;
        }

        public Propietario GetPropietario(int IdPropietario)
        {
            return propietario.SingleOrDefault(s => s.Id==IdPropietario);
        }

        public Propietario UpdatePropietario(Propietario propietarioactualizado)
        {
            var Propietarios= propietario.SingleOrDefault(r => r.Id==propietarioactualizado.Id);
            if(Propietarios!=null)
            {
                Propietarios.Id=propietarioactualizado.Id;
                Propietarios.Nombre=propietarioactualizado.Nombre;
                Propietarios.Apellidos=propietarioactualizado.Apellidos;
                Propietarios.Cedula=propietarioactualizado.Cedula;
                Propietarios.Correo=propietarioactualizado.Correo;
                Propietarios.Direccion=propietarioactualizado.Direccion;
                Propietarios.Telefono=propietarioactualizado.Telefono;
            }
            return Propietarios;
        }

        public Propietario UpdatePropietario(Propietario propietario, int idPropietario)
        {
            throw new System.NotImplementedException();
        }
    }
}