using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula02_OrientacaoObjetos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula02_OrientacaoObjetos.Controllers
{
    public class PessoaController : Controller
    {
        public static List<Pessoa> lsPessoa = new List<Pessoa>(); 
        public IActionResult Index()
        {
            return View(lsPessoa);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Listar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult salvar(Pessoa item)
        {
            lsPessoa.Add(item);
            return RedirectToAction("Index");
        }
    }
}
