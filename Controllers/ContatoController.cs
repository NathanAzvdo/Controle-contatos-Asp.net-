using ControledeContatos.Models;
using ControledeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ControledeContatos.Controllers
{
    public class ContatoController : Controller
    { 
        private readonly icontatoRepositorio _contatoRepositorio;
        public ContatoController(icontatoRepositorio contatoRepositorio){
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.buscarTodos();
            return View(contatos);
        }
        public IActionResult criar()
        {
            return View();
        }
        public IActionResult editar(int id)
        {
            ContatoModel ctt = _contatoRepositorio.BuscarId(id);
            return View(ctt);
        }
        public IActionResult apagarConf(int id)
        {
            ContatoModel ctt = _contatoRepositorio.BuscarId(id);
            return View(ctt);
        }
        public IActionResult Apagar(int id){
            _contatoRepositorio.apagar(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult criar(ContatoModel contato){
            if(ModelState.IsValid){
                _contatoRepositorio.adicionar(contato);
                return RedirectToAction("index");
            }
            else{
                return View(contato);
            }
            
        }       
        [HttpPost]
        public IActionResult alterar(ContatoModel contato){
            _contatoRepositorio.atualizar(contato);
            return RedirectToAction("index");
        }
        
    }
}