using ControledeContatos.Models;
using ControledeContatos.Repositorio;
namespace ControledeContatos.Repositorio
{
    public interface icontatoRepositorio
    {
        bool apagar(int id);
        ContatoModel atualizar(ContatoModel contato);
        ContatoModel BuscarId(int id);
        List<ContatoModel> buscarTodos();
     ContatoModel adicionar(ContatoModel contato);    
    }
}