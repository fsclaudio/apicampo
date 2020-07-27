using System;
using System.ComponentModel.DataAnnotations;

namespace apicampo.Models
{
    public class Variaveis
    {
        public Guid id {get; set;}
        public DateTime date{get; set;}
        [Required]
        public string varia{get; set;}
        [Required]
        public string valor_dia{get; set;}
        [Required]
        public string val_safra{get; set;}
    }
    
}