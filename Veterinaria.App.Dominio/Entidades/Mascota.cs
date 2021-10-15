using System;
namespace Veterinaria.App.Dominio
{
  public class Mascota
  {
      public int id{get;set;}
      public string Nombre{get;set;}
      public string Edad{get;set;}
      public string Tipo_Mascota{get;set;}
      public string Estado_Salud{get;set;}
      public Propietario dueño{get;set;}

  }  
}