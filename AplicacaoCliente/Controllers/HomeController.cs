using AplicacaoCliente.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoCliente.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ListagemCliente = ClienteModel.ListarTodosCliente();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Registrar(int? id)
        {
            if (id != null)
                ViewBag.Registro = new ClienteModel().Carregar(id);

            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            ViewData["ClienteID"] = id;

            return View();
        }

        public IActionResult ExcluirCliente(int? id)
        {
            new ClienteModel().Excluir(id);

            return View();
        }

        [HttpPost]
        public IActionResult Registrar(ClienteModel clienteModel)
        {
            if(clienteModel.Id != 0)
            {
                clienteModel.Atualizar();
            }
            else
            {
                clienteModel.Inserir();
            }

            return View();
        }
    }
}
