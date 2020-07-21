using System;
using System.ComponentModel.DataAnnotations;

namespace apicampo.Models
{
    
    public class Tarefa
    {
       public Guid id {get; set;}
       public Guid UsuarioId {get; set; }
       
       [Required]
       public string nome {get; set; }
       public bool Concluida {get; set ; } = false;
    }
}