using ControledeContatos.data;
using ControledeContatos.Models;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace ControledeContatos.Repositorio
{
    public class contatoRepositorio : icontatoRepositorio
    {   
        public readonly bancoContext _bancoContext;
        public contatoRepositorio(bancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public List<ContatoModel> buscarTodos(){
            return _bancoContext.Contatos.ToList();
        }
        public ContatoModel adicionar(ContatoModel contato)
        {
            //insert
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }
    }
}