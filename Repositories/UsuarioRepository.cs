using System;
using System.Linq;
using apicampo.Models;

namespace apicampo.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario Read(string email, string senha);
        void Create (Usuario usuario);
        
    }
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _context;
        public UsuarioRepository(DataContext context)
        {
            _context=context;
        }
        public void Create(Usuario usuario)
        {
            usuario.id= Guid.NewGuid();
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

        }

        public Usuario Read(string email, string senha)
        {
           return _context.Usuarios.SingleOrDefault(
               usuario => usuario.email == email && usuario.senha == senha
           );
        }
    }

}