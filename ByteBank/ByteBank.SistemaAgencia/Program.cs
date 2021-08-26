using ByteBank.ExpressoesRegulares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            TesteSubstring();

            Console.ReadLine();
        }

        public static void TesteSubstring()
        {

            Console.WriteLine(ManipulandoCaracteres.TextoSubstring("pagina?argumentos", 7));
        }

    }
}
