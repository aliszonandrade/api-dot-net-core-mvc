using AplicacaoCliente.Util;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoCliente.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataCadastro { get; set; }
        public string CpfCnpj { get; set; }
        public char Tipo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string DataNascimento { get; set; }

        public static List<ClienteModel> ListarTodosCliente()
        {
            string json = WebAPI.RequestGET("listagem", string.Empty);
            return JsonConvert.DeserializeObject<List<ClienteModel>>(json);
        }

        public void Inserir()
        {
            WebAPI.RequestPOST("registrarCliente", JsonConvert.SerializeObject(this));
        }

        public ClienteModel Carregar(int? id)
        {
            string json = WebAPI.RequestGET("retornarcliente", id.ToString());
            return JsonConvert.DeserializeObject<ClienteModel>(json);
        }

        public void Atualizar()
        {
            WebAPI.RequestPUT("atualizarCliente/" + this.Id, JsonConvert.SerializeObject(this));
        }

        public void Excluir(int? id)
        {
            WebAPI.RequestDELETE("excluir", id.ToString());
        }
    }
}