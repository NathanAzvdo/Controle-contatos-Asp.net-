using ControledeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControledeContatos.data
{
    public class bancoContext : DbContext
    {
        public DbSet<ContatoModel> Contatos{get; set;}
        
        public bancoContext(DbContextOptions <bancoContext> options) : base(options)
        {
            Contatos = Set<ContatoModel>();
        }

    }
}