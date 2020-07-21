using System;
using System.Collections.Generic;
using System.Linq;
using apicampo.Models;
using Microsoft.EntityFrameworkCore;

namespace apicampo.Repositories
{
    public interface ITarefaRepository
    {
        List<Tarefa> Read(Guid id);
        void Create(Tarefa tarefa);
        void Delete(Guid id);
        void Update(Guid id, Tarefa tarefa);
    }
    public class TarefaRepository : ITarefaRepository
    {
        private readonly DataContext _context;
        public TarefaRepository(DataContext context)
        {
           _context=context; 
        }
        public void Create(Tarefa tarefa)
        {
           tarefa.id = Guid.NewGuid();
           _context.Tarefas.Add(tarefa);
           _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
           var tarefa =  _context.Tarefas.Find(id);
           _context.Entry(tarefa).State = EntityState.Deleted;
           _context.SaveChanges();

        }

        public List<Tarefa> Read(Guid id)
        {
           return _context.Tarefas.Where(Tarefa => Tarefa.UsuarioId == id).ToList();
        }

        public void Update(Guid id, Tarefa tarefa)
        {
           var _tarefa =  _context.Tarefas.Find(id);
           _tarefa.nome=tarefa.nome;
           _tarefa.Concluida=tarefa.Concluida;
           _context.Entry(_tarefa).State = EntityState.Modified;
           _context.SaveChanges();

        }
    }
}