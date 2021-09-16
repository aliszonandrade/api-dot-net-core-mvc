using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoCliente.Util
{
    public class WebAPI
    {
        public static string URI = "https://localhost:44311/api/cliente/";

        public static string RequestGET(string pMetodo, string pParametro)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(URI + pMetodo + "/" + pParametro);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
        
        public static string RequestDELETE(string pMetodo, string pParametro)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(URI + pMetodo + "/" + pParametro);
            request.Method = "DELETE";
            request.Headers.Add("Token", "q3h1u3hifose");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        public static string RequestPOST(string pMetodo, string pJsonData)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI + pMetodo);
            byte[] data = Encoding.ASCII.GetBytes(pJsonData);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        public static string RequestPUT(string pMetodo, string pJsonData)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI + pMetodo);
            byte[] data = Encoding.ASCII.GetBytes(pJsonData);
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

    }
}
