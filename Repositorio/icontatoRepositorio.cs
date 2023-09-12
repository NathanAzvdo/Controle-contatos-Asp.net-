using ControledeContatos.Models;

namespace ControledeContatos.Repositorio
{
    public interface icontatoRepositorio
    {
        List<ContatoModel> buscarTodos();
     ContatoModel adicionar(ContatoModel contato);    
    }
}