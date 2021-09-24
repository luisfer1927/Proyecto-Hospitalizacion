using System;
namespace Veterinaria.App.Dominio
{
  public class Mascota
  {
      public int id_Mascota{get;set;}
      public string Nombre{get;set;}
      public int Edad{get;set;}
      public string Tipo_Mascota{get;set;}
      public bool Estado_Salud{get;set;}
      public Propietario dueño{get;set;}

  }  
}