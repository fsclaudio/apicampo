using System;
using System.Collections.Generic;
using System.Linq;
using apicampo.Models;
using Microsoft.EntityFrameworkCore;

namespace apicampo.Repositories
{
  public interface IIndicadoresRepository
  {
        List<Indicadores> Read();
        Indicadores Find(String varia);
        void Create(Indicadores indicares);
        void Delete(Guid id);
        void Update(Guid id, Indicadores indicadores);
  }  
  public class IndicadoresRepository : IIndicadoresRepository
    {
        private readonly DataContext _context;
        public IndicadoresRepository (DataContext context){
            _context=context;
        }

        public void Create(Indicadores indicares)
        {
            indicares.id =  Guid.NewGuid();
            _context.Indcadores.Add(indicares);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var indicadores =  _context.Indcadores.Find(id);
           _context.Entry(indicadores).State = EntityState.Deleted;
           _context.SaveChanges();
        }

        public Indicadores Find(String varia)
        {
            return _context.Indcadores.FirstOrDefault(t => t.VARIAVEL == varia);
        }

        public List<Indicadores> Read()
        {
            return _context.Indcadores.ToList();
        }

        public void Update(Guid id, Indicadores indicadores)
        {
            throw new NotImplementedException();
        }
    }
}