using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App1_ConsultarCep.Serviço.Modelo;
using Newtonsoft.Json;

namespace App1_ConsultarCep.Serviço
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCep(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();

            string Conteudo = wc.DownloadString(NovoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            if (end.cep == null) return null;

            return end;


        }
    }
}
