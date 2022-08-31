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
        public string Escolha()
        {
            Soma = Valor1 + Valor2;
            switch (Soma)
            {
                case 0:
                    return "PROXYCITY";
                        
                case 1:
                    return "P.Y.N.G.";
                        
                case 2:
                    return "DNSUEY!";
                        
                case 3:
                    return "SERVERS";
                        
                case 4:
                    return "HOST!";
                        
                case 5:
                    return "CRIPTONIZE";
                        
                case 6:
                    return "OFFLINE DAY";
                        
                case 7:
                    return "SALT";
                       
                case 8:
                    return "ANSWER!";
                        
                case 9:
                    return"RAR ?";
                       
                case 10:
                    return "WIFI ANTENNAS";
                        

                default:
                    return "Valor muito alto";
                    
            }
        }

    }
}
