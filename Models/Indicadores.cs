using System;

namespace apicampo.Models
{
  public class Indicadores{
       public Guid id {get;set;} 
       public string VARIAVEL{get;set;}
       public string DATA{get;set;}
       public string HORA{get;set;}
       public string VALOR{get;set;}
       public string DESCRICAO{get;set;}
  }    
}