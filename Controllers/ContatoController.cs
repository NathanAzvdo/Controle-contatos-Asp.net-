using ControledeContatos.Models;
using ControledeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

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
        public IActionResult editar()
        {
            return View();
        }
        public IActionResult apagarConf()
        {
            return View();
        }
        [HttpPost]
        public IActionResult criar(ContatoModel contato){
            _contatoRepositorio.adicionar(contato);
            return RedirectToAction("index");
        }
        
    }
}