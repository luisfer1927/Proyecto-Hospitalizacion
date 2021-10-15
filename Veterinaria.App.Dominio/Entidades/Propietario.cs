using System;
using System.ComponentModel.DataAnnotations;

namespace Veterinaria.App.Dominio
{
  public class Propietario:Persona
  {
      public string Cedula{get;set;}
      public string Direccion{get;set;}
      public string Correo{get;set;}
      
  }  
}