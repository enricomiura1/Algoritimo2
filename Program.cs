using System;

namespace Algoritimo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleAcesso controleAcesso = new ControleAcesso();

            //bool logado = controleAcesso.EfetuarLogin();
            //if (logado)
            //    Console.WriteLine("loguin efetuado com sucesso!");







            ////Numeros primos
            NumerosPrimos numerosPrimos = new NumerosPrimos();
            Console.WriteLine("Digite um limite");
            numerosPrimos.limite = Convert.ToInt32(Console.ReadLine());
            numerosPrimos.CalcularNumerosPrimos();

            












            /// Calculo imc
            // Console.WriteLine("Digite seu peso (KG);");
            // int peso = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Digite sua Altuta (m);");
            // double altura = Convert.ToDouble(Console.ReadLine());

            // double imc = peso / (altura * altura);
            //string  resultado = "";

            // if (imc < 17)
            //     resultado = "Muito abaixo do peso";

            // if (imc >= 17 && imc <= 18.49)
            //     resultado = " Abaixo do peso";

            // if (imc > 18.49 && imc < 25)
            //     resultado = "Peso normal";

            // if (imc > 25 && imc < 30)
            //     resultado = "Acima do Peso ";

            // if (imc >= 30 && imc < 35)
            //     resultado = "Obesidade 1";

            // if (imc >= 35 && imc < 40)
            //     resultado = "Obesidade 2";

            // if (imc >= 40) ;
            //     resultado = "Tu é um elefante";

            // Console.WriteLine(resultado);


        }
    }
}
