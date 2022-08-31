using System;

namespace TocarMusica
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com quantos testes pretende fazer :");
            int testes = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a música: ");
            Console.WriteLine("0 - PROXYCITY");
            Console.WriteLine("1 - P.Y.N.G. ");
            Console.WriteLine("2 - DNSUEY!");
            Console.WriteLine("3 - SERVERS");
            Console.WriteLine("4 - HOST!");
            Console.WriteLine("5 - CRIPTONIZE");
            Console.WriteLine("6 - OFFLINE DAY");
            Console.WriteLine("7 - SALT");
            Console.WriteLine("8 - ANSWER!");
            Console.WriteLine("9 - RAR?");
            Console.WriteLine("10 - WIFI ANTENNAS");
            Console.WriteLine();
            Console.Write("Digite 2 números que somados dão a sua escolha: ");


            try
            {
                for (int i = 1; i < testes + 1; i++)
                {

                    string[] valores = Console.ReadLine().Split(' ');
                    int valor1 = int.Parse(valores[0]);
                    int valor2 = int.Parse(valores[1]);

                    EscolhaMusica escolha = new EscolhaMusica(valor1, valor2);

                    Console.WriteLine(escolha.Escolha());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(" ");
            }



            Console.WriteLine("Precione qualquer tecla para fechar: ");

        }
    }
}
