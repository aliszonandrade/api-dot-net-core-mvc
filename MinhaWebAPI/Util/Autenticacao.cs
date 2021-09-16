using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaWebAPI.Util
{
    public class Autenticacao
    {
        public static string Token = "q3h1u3hifose";
        public static string FALHA_AUTENTICACAO = "Falha na autenticação! O token informado é inválido";
        IHttpContextAccessor ContextAccessor;

        public Autenticacao(IHttpContextAccessor contextAccessor)
        {
            ContextAccessor = contextAccessor;
        }

        public void Autenticar()
        {
            try
            {
                string TokenRecebido = ContextAccessor.HttpContext.Request.Headers["Token"].ToString();

                if(!String.Equals(Token, TokenRecebido))
                    throw new Exception(FALHA_AUTENTICACAO);
            }
            catch
            {
                throw new Exception(FALHA_AUTENTICACAO);
            }
        }
    }
}
