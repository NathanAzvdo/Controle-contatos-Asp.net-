using ControledeContatos.data;
using ControledeContatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using ControledeContatos.Repositorio;

namespace ControledeContatos.Repositorio
{
    public class ContatoRepositorio : icontatoRepositorio
    {   
        private readonly bancoContext _bancoContext;

        public ContatoRepositorio(bancoContext bancoContext)
        {
            _bancoContext = bancoContext ?? throw new ArgumentNullException(nameof(bancoContext));
        }

        public List<ContatoModel> buscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel BuscarId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public ContatoModel adicionar(ContatoModel contato)
        {
            if (contato == null)
            {
                throw new ArgumentNullException(nameof(contato));
            }

            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel atualizar(ContatoModel contato)
        {
            if (contato == null)
            {
                throw new ArgumentNullException(nameof(contato));
            }

            var contatoDb = BuscarId(contato.Id);

            if (contatoDb == null)
            {
                throw new InvalidOperationException("Contato não encontrado para atualização");
            }

            contatoDb.Nome = contato.Nome;
            contatoDb.Email = contato.Email;
            contatoDb.celular = contato.celular;

            _bancoContext.Contatos.Update(contatoDb);
            _bancoContext.SaveChanges();

            return contatoDb;
        }

        public bool apagar(int id)
        {
            var contato = BuscarId(id);

            if (contato == null)
            {
                throw new InvalidOperationException("Contato não encontrado para exclusão");
            }

            _bancoContext.Contatos.Remove(contato);
            _bancoContext.SaveChanges();
            return true;
        }

       
    }
}
