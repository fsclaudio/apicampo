using System;
using System.Collections.Generic;
using System.Linq;
using apicampo.Models;
using Microsoft.EntityFrameworkCore;

namespace apicampo.Repositories
{
  public interface IIndicadoresRepository
  {
        List<INDICADORES> Read();
        INDICADORES Find(String varia);
        void Create(INDICADORES indicares);
        void Delete(Guid id);
        void Update(Guid id, INDICADORES indicadores);
  }  
  public class IndicadoresRepository : IIndicadoresRepository
    {
        private readonly DataContext _context;
        public IndicadoresRepository (DataContext context){
            _context=context;
        }

        public void Create(INDICADORES indicares)
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

        public INDICADORES Find(String varia)
        {
            return _context.Indcadores.FirstOrDefault(t => t.VARIAVEL == varia);
        }

        public List<INDICADORES> Read()
        {
            return _context.Indcadores.ToList();
        }

        public void Update(Guid id, INDICADORES indicadores)
        {
            throw new NotImplementedException();
        }
    }
}