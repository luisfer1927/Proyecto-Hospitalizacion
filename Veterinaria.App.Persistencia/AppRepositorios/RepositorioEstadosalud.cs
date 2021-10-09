using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioEstadosalud : IRepositorioEstadosalud
    {

         List<EstadodeSalud> salud;

        public RepositorioEstadosalud()
        {
            salud = new List<EstadodeSalud>()
            {
                new EstadodeSalud{id=1,temperatura=33,Frecu_Respi=33,Frecu_Cardia=33,Estado_Animo="desanimado",recomendacion="mejorar alimentacion",Peso=12,masco_estadosalud=new Mascota{id=1,Nombre="TROSKI",Edad="15",Tipo_Mascota="PERRO",Estado_Salud="SALUDABLE",dueño="MATEO"},visit=new Visita{id=1,Fecha="12-07-18",Motivo_Visita="estado salud",veterinario_visita=new Veterinario{Id=1,Nombre="Mateo",Apellidos="Salazar Ortiz",Telefono="3182909852",Targeta_Profesional=123}}},
                new EstadodeSalud{id=2,temperatura=33,Frecu_Respi=33,Frecu_Cardia=33,Estado_Animo="Feliz",recomendacion="segguir asi",Peso=7,masco_estadosalud=new Mascota{id=2,Nombre="Firulais",Edad="15",Tipo_Mascota="PERRO",Estado_Salud="SALUDABLE",dueño="MATEO"},visit=new Visita{id=1,Fecha="12-08-18",Motivo_Visita="estado salud",veterinario_visita=new Veterinario{Id=2,Nombre="Mateo",Apellidos="Salazar Ortiz",Telefono="3182909852",Targeta_Profesional=123}}},
                new EstadodeSalud{id=3,temperatura=33,Frecu_Respi=33,Frecu_Cardia=33,Estado_Animo="bien",recomendacion="limpiar la boca seguido",Peso=11,masco_estadosalud=new Mascota{id=3,Nombre="luna",Edad="15",Tipo_Mascota="PERRO",Estado_Salud="SALUDABLE",dueño="MATEO"},visit=new Visita{id=1,Fecha="12-010-18",Motivo_Visita="estado salud",veterinario_visita=new Veterinario{Id=3,Nombre="Mateo",Apellidos="Salazar Ortiz",Telefono="3182909852",Targeta_Profesional=123}}},
            };
        }
        public EstadodeSalud Addsalud(EstadodeSalud salud)
        {
            throw new System.NotImplementedException();
        }
        public void Deletesalud(int idEstadodeSalud)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<EstadodeSalud> GetAll()
        {
           return salud;
        }
        public EstadodeSalud Getsalud(int idsalud)
        {
            throw new System.NotImplementedException();
        }
        public EstadodeSalud Updatesalud(EstadodeSalud salud)
        {
            throw new System.NotImplementedException();
        }
        public EstadodeSalud Updatesalud(EstadodeSalud salud, int idsalud)
        {
            throw new System.NotImplementedException();
        }

    }
}