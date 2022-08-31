using System;
using System.Collections.Generic;
using System.Text;

namespace TocarMusica
{
    class EscolhaMusica
    {
        private int Valor1 { get; set; }
        private int Valor2 { get; set; }
        private int Soma { get; set; }

        public EscolhaMusica()
        {
        }

        public EscolhaMusica(int valor1, int valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }
        public void Escolha()
        {
            Soma = Valor1 + Valor2;
            switch (Soma)
            {
                case 0:
                    Console.WriteLine("PROXYCITY");
                    break;  
                case 1:
                    Console.WriteLine("P.Y.N.G.");
                    break;
                case 2:
                    Console.WriteLine("DNSUEY!");
                    break;
                case 3:
                    Console.WriteLine("SERVERS");
                    break;
                case 4:
                    Console.WriteLine("HOST!");
                    break;
                case 5:
                    Console.WriteLine("CRIPTONIZE");
                    break;
                case 6:
                    Console.WriteLine("OFFLINE DAY");
                    break;
                case 7:
                    Console.WriteLine("SALT");
                    break;
                case 8:
                    Console.WriteLine("ANSWER!");
                    break;
                case 9:
                    Console.WriteLine("RAR ?");
                    break;
                case 10:
                    Console.WriteLine("WIFI ANTENNAS");
                    break;

                default:
                    Console.WriteLine("Valor muito alto");
                    break;
            }
        }

    }
}
