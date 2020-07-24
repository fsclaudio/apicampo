using System;
using System.Collections.Generic;
using System.Linq;
using apicampo.Models;
using Microsoft.EntityFrameworkCore;

namespace apicampo.Repositories
{
    public interface IVariaveisRepository
    {
        List<Variaveis> Read();
       void Create (Variaveis variaveis ); 
       void Delete(Guid id);
       void Update(Guid id, Variaveis variaveis);
           
    }
    public class VariaveisRepository : IVariaveisRepository
    {
       private readonly DataContext _context;
       public VariaveisRepository(DataContext context)
       {
           _context=context;
       }

        public void Create(Variaveis variaveis)
        {
            variaveis.id = Guid.NewGuid();
            _context.Variaveis.Add(variaveis);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
           var variaveis =  _context.Variaveis.Find(id);
           _context.Entry(variaveis).State = EntityState.Deleted;
           _context.SaveChanges();
        }

        public List<Variaveis> Read()
        {
            return _context.Variaveis.ToList();
        }

        public void Update(Guid id, Variaveis variaveis)
        {
            var _Varia =  _context.Variaveis.Find(id);
           _Varia.date=variaveis.date;
           _Varia.varia = variaveis.varia;
           _Varia.valor_dia=variaveis.valor_dia;
           _Varia.val_safra=variaveis.val_safra;
           _context.Entry(_Varia).State = EntityState.Modified;
           _context.SaveChanges();
        }
    }
    
}