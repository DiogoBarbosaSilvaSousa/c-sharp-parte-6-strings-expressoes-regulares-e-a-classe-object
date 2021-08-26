using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.ExpressoesRegulares
{
    /// <summary>
    /// Biblioteca que mostra como manipular strings no C#
    /// </summary>
    public class ManipulandoCaracteres
    {
        /// <summary>
        /// Mostra como o método Substring funciona.
        /// </summary>
        /// <param name="texto">Texto a ser modificado</param>
        /// <param name="inicia">Número do caractere onde o texto se inicia.</param>
        /// <returns></returns>
        public static string TextoSubstring(string texto, int inicia)
        {
            string textoAlterado = texto;

            return textoAlterado.Substring(inicia);
        }

    }
}
