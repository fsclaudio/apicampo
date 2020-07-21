using System;
using System.ComponentModel.DataAnnotations;

namespace apicampo.Models
{
  public class Usuario
  {
      public Guid id {get;set;}
        [Required]
      public string nome{get;set;}
       [Required]
      public string email {get; set;}
       [Required]
      public string senha {get; set; }
  }
}