﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadorTernario {
        public static void Executar () {
            var nota = 9.0;
            bool bomComportamento = false;
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            // o string também pode ser var.
            Console.WriteLine(resultado);
        }
    }
}
