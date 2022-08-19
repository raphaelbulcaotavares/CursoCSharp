using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar () {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            // && operador lógico do "e", ou seja, os dois tem que ser verdade, para dar verdade.
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            // operador lógico || é do ou
            Console.WriteLine("Comprou o sorvete {0}", comprouSorvete);


            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            // operador lógico do ^ é do ou exclusivo (ou isso ou aquilo).
            Console.WriteLine("Comprou a Tv32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
            // ! é negação

        }
    }
}
