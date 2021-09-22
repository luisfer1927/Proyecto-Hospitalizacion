using System;
namespace Veterinaria.App.Dominio
{
  public class Visita
  {
      public DateTime Fecha{get;set;}
      public string Motivo_Visita{get;set;}
      public Veterinario veterinario_visita{get;set;}
  }  
}