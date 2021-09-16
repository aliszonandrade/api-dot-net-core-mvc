using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaWebAPI.Models;
using MinhaWebAPI.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        Autenticacao ServicoAutenticacao;

        public ClienteController(IHttpContextAccessor contextAccessor)
        {
            ServicoAutenticacao = new Autenticacao(contextAccessor);
        }

        // GET api/values
        [HttpGet]
        [Route("listagem")]
        public List<ClienteModel> Listagem()
        {
            return new ClienteModel().Listagem();
        }

        // GET api/values/5
        [HttpGet]
        [Route("retornarcliente/{id}")]
        public ClienteModel RetornarCliente(int id)
        {
            return new ClienteModel().RetornarCliente(id);
        }

        // POST api/values
        [HttpPost]
        [Route("registrarCliente")]
        public ReturnAllServices RegistrarCliente([FromBody] ClienteModel dados)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                dados.RegistrarCliente();

                retorno.Result = true;
                retorno.ErrorMessage = string.Empty;
                
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = "Erro ao tentar registrar um cliente: " + ex.Message;
            }

            return retorno;
        }

        // PUT api/values/5
        [HttpPut]
        [Route("atualizarCliente/{id}")]
        public ReturnAllServices Put(int id, [FromBody] ClienteModel dados)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                dados.AtualizarCliente(id);

                retorno.Result = true;
                retorno.ErrorMessage = string.Empty;

            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = "Erro ao tentar atualizar um cliente: " + ex.Message;
            }

            return retorno;
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("excluir/{id}")]
        public ReturnAllServices Excluir(int id)
        {
            ReturnAllServices retorno = new ReturnAllServices();

            try
            {
                ServicoAutenticacao.Autenticar();
                new ClienteModel().Excluir(id);

                retorno.Result = true;
                retorno.ErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
        }
    }
}
