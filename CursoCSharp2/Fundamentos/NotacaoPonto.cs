using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto 
    {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo").ToUpper();
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            // a inclusão da interrogação depois da palavra, cujo valor está vazio, faz com que o c# identifique se 
            // é um valor válido ou não. Se não for, ele é ignorado.

            /* o importante agora é entender que a notação ponto está associada a diversas funcionalidades.
            */ 
        }
    }
}
