using MinhaWebAPI.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaWebAPI.Models
{
    public class ClienteModel
    {
        public int Id;

        public string Nome;

        public DateTime DataCadastro;

        public string CpfCnpj;

        public char Tipo;

        public string Telefone;

        public string Email;

        public string CEP;

        public string Logradouro;

        public string Numero;

        public string Bairro;

        public string Complemento;

        public string Cidade;

        public string UF;

        public DateTime DataNascimento;

        public void RegistrarCliente()
        {
            DAL dal = new DAL();
            string query  = "INSERT INTO CLIENTE" +
                "(NOME, DATA_CADASTRO, CPF_CNPJ, TIPO, TELEFONE, EMAIL, CEP, LOGRADOURO, NUMERO, BAIRRO, COMPLEMENTO, CIDADE, UF, DATA_NASCIMENTO)" +
                "VALUES" +
                $"('{Nome}', '{DataCadastro.ToString("yyyy/MM/dd")}', '{CpfCnpj}', '{Tipo}', '{Telefone}', '{Email}', '{CEP}', '{Logradouro}', '{Numero}', '{Bairro}', '{Complemento}', '{Cidade}', '{UF}', '{DataNascimento}')";

            dal.ExecutarComandoSQL(query);
        }

        public List<ClienteModel> Listagem()
        {
            List<ClienteModel> listaClientes = new List<ClienteModel>();
            ClienteModel item;

            DAL dal = new DAL();

            string query = "SELECT * FROM CLIENTE";

            DataTable dt = dal.RetornarDados(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ClienteModel()
                {
                    Id = Int32.Parse(dt.Rows[i]["ID"].ToString()),
                    Nome = dt.Rows[i]["NOME"].ToString(),
                    DataCadastro = DateTime.Parse(dt.Rows[i]["DATA_CADASTRO"].ToString()),
                    CpfCnpj = dt.Rows[i]["CPF_CNPJ"].ToString(),
                    Tipo = Convert.ToChar(dt.Rows[i]["TIPO"].ToString()),
                    Telefone = dt.Rows[i]["TELEFONE"].ToString(),
                    Email = dt.Rows[i]["EMAIL"].ToString(),
                    CEP = dt.Rows[i]["CEP"].ToString(),
                    Logradouro = dt.Rows[i]["LOGRADOURO"].ToString(),
                    Numero = dt.Rows[i]["NUMERO"].ToString(),
                    Bairro = dt.Rows[i]["BAIRRO"].ToString(),
                    Complemento = dt.Rows[i]["COMPLEMENTO"].ToString(),
                    Cidade = dt.Rows[i]["CIDADE"].ToString(),
                    UF = dt.Rows[i]["UF"].ToString(),
                    DataNascimento = DateTime.Parse(dt.Rows[i]["DATA_NASCIMENTO"].ToString())
                };

                listaClientes.Add(item);
            }

            return listaClientes;

        }

        public void Excluir(int id)
        {
            DAL dal = new DAL();
            string query = $"DELETE FROM CLIENTE WHERE ID = {id}";
            dal.ExecutarComandoSQL(query);
        }

        public ClienteModel RetornarCliente(int id)
        {
            DAL dal = new DAL();

            string query = $"SELECT * FROM CLIENTE WHERE ID = {id}";

            DataTable dt = dal.RetornarDados(query);

            ClienteModel retorno = new ClienteModel()
            {
                Id = Int32.Parse(dt.Rows[0]["ID"].ToString()),
                Nome = dt.Rows[0]["NOME"].ToString(),
                DataCadastro = DateTime.Parse(dt.Rows[0]["DATA_CADASTRO"].ToString()),
                CpfCnpj = dt.Rows[0]["CPF_CNPJ"].ToString(),
                Tipo = Convert.ToChar(dt.Rows[0]["TIPO"].ToString()),
                Telefone = dt.Rows[0]["TELEFONE"].ToString(),
                Email = dt.Rows[0]["EMAIL"].ToString(),
                CEP = dt.Rows[0]["CEP"].ToString(),
                Logradouro = dt.Rows[0]["LOGRADOURO"].ToString(),
                Numero = dt.Rows[0]["NUMERO"].ToString(),
                Bairro = dt.Rows[0]["BAIRRO"].ToString(),
                Complemento = dt.Rows[0]["COMPLEMENTO"].ToString(),
                Cidade = dt.Rows[0]["CIDADE"].ToString(),
                UF = dt.Rows[0]["UF"].ToString(),
                DataNascimento = DateTime.Parse(dt.Rows[0]["DATA_NASCIMENTO"].ToString())
            };

            return retorno;

        }

        public void AtualizarCliente(int pId)
        {
            DAL dal = new DAL();
            string query = "UPDATE CLIENTE SET " +
                $"NOME = '{Nome}', " +
                $"DATA_CADASTRO = '{DataCadastro.ToString("yyyy/MM/dd")}', " +
                $"CPF_CNPJ = '{CpfCnpj}', " +
                $"TIPO = '{Tipo}', " +
                $"TELEFONE = '{Telefone}', " +
                $"EMAIL = '{Email}', " +
                $"CEP = '{CEP}', " +
                $"LOGRADOURO = '{Logradouro}', " +
                $"NUMERO = '{Numero}', " +
                $"BAIRRO = '{Bairro}', " +
                $"COMPLEMENTO = '{Complemento}', " +
                $"CIDADE = '{Cidade}', " +
                $"UF = '{UF}', " +
                $"DATA_NASCIMENTO = '{DataNascimento}' WHERE ID = {pId}";

            dal.ExecutarComandoSQL(query);
        }
    }
}
