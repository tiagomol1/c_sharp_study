﻿using System;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper()
                .Insert(3, " World!")
                .Replace("World!", "Mundo!");
            
            Console.WriteLine(saudacao);
            Console.WriteLine("teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);

        }
    }
}
