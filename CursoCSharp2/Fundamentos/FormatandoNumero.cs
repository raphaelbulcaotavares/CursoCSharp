using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            //Essa função arredonda o número desejado. No caso supracitado, irá para 15,2

            Console.WriteLine(valor.ToString("C"));
            // Essa função "C" usa o "currency", ou seja, transforma para um valor monetário. No caso, será o R$.

            Console.WriteLine(valor.ToString("P"));
            //Função "p" dá um percentual

            Console.WriteLine(valor.ToString("#.##"));
            //Função para colocar o número acima com duas casas decimais. No caso, 15,18

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", cultura));
            //C2 = CURRENCY mais duas casas decimais. C3 = três casas decimais.

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
            // ACRESCENTA zeros a esquerda



        
        }
    }
}
