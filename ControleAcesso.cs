using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritimo2
{
    class ControleAcesso
    {
       public string login = "Enrico";
        public string senha = "1010";

        public bool EfetuarLogin()
        {
            bool retorno = false;
            Console.WriteLine("Digite o login:");
            string loginDigitado = Console.ReadLine();



            if (loginDigitado == login)
            {
                int count = 0;

                while (count < 3)
                {
                    Console.WriteLine("Digite a Senha:");
                    string senhaDigitada = Console.ReadLine();

                    if (senhaDigitada == senha)
                    {
                        retorno = true;
                        break;
                    }
                    count++;
                }
               
            }
            return retorno;
        }
    }
}
