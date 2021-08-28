using ByteBank.ExpressoesRegulares;
using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // TesteSubstring();

            // TesteExtratorUrl();

            // TestLength();

            // TestUrlParametro();

            // TestVerificaUrl();

            // TestExpressaoRegular();

            // TestExpressaoRegularRefinado();

            // TestSobrescrevendoToString();

            TestComparandoObjetos();

            Console.ReadLine();
        }

        public static void TesteSubstring()
        {

            Console.WriteLine(ManipulandoCaracteres.TextoSubstring("pagina?argumentos", 7));
        }

        public static void TesteExtratorUrl()
        {
            // pagina?argumentos
            // 012345678


            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "kjhfsdjhgsdfjksdf";


            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();


            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

        }

        public static void TesteIndexOf()
        {
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);
        }

        public static void TestLength()
        {
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));
            Console.ReadLine();
        }

        public static void TestUrlParametro()
        {
            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valor);

            string valormoedaDestino = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valormoedaDestino);

            Console.WriteLine(extratorDeValores.GetValor("valor"));
        }

        public static void TestVerificaUrl()
        {
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine("StartWith: " + urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine("EndsWith: " + urlTeste.EndsWith("cambio"));
            Console.WriteLine("Contains: " + urlTeste.Contains("ByteBank"));

            Console.WriteLine("IndexOf: " + (indiceByteBank == 0));
        }

        public static void TestExpressaoRegular()
        {
            string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            string textoDeTeste = "Meu nome é Guilherme, me ligue em 4784-4546";
            
            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);

        }

        public static void TestExpressaoRegularRefinado()
        {
            string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            string textoDeTeste = "Meu nome é Guilherme, me ligue em 4784-4546";

            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);

        }

        public static void TestSobrescrevendoToString()
        {
            ContaCorrente conta = new ContaCorrente(497, 85558);

            Console.WriteLine(conta);
        }

        public static void TestComparandoObjetos()
        {
            ContaCorrente conta = new ContaCorrente(497, 85558);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "123.344.553-1";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "123.344.553-1";
            carlos_2.Profissao = "Designer";

            if(carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }
        }
    }
}
