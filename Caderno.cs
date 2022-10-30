using System;
using System.Collections.Generic;
using System.Text;

namespace MeuMaterialEscolar
{
    class Caderno
    {
        private int quantfolhas;
        private int quantmateria;
        private string marca;
        private string tipocapa;
        private bool pauta;
        private string espiral;
        public bool aberto;

        public int Getquantfolhas()
        {
            return this.quantfolhas;
        }
        public void Setquantfolha( int Qf)
        {
            this.quantfolhas = Qf;
        }

        public int Getquantmateria()
        {
            return this.quantmateria;
        }
        public void Setquantmateria(int Qm)
        {
            this.quantmateria = Qm;
        }

        public string Getmarca()
        {
            return this.marca;
        }
        public void Setmarca(string M)
        {
            this.marca = M;
        }

        public string Gettipocapa()
        {
            return this.tipocapa;
        }
        public void Settipocapa(string Tc)
        {
            this.tipocapa = Tc;
        }

        public bool Getpauta()
        {
            return this.pauta;
        }
        public void Setpauta(bool P)
        {
            this.pauta = P;
        }

        public string Getarame()
        {
            return this.espiral;
        }
        public void Setespiral(bool A)
        {
            if (A == true)
            {
                this.espiral = "Sim";
            }
            else
            {
                this.espiral = "Não";
            }
        }

        public void Abrir()
        {
            if (aberto == true)
            {
                Console.WriteLine(" Não é necessario abrir o caderno, pois ele ja está aberto");
            }
            else
            {
                Console.WriteLine(" Abra o caderno");
            }
        }
        public void Fechar()
        {
            if (aberto == false)
            {
                Console.WriteLine(" O caderno já está fechado");
            }
            else
            {
                Console.WriteLine(" Feche o caderno");
            }
        }
        public void Arrancarfolha()
        {
            if (aberto == true)
            {
                Console.WriteLine("\n Arranque uma folha");
            }
            else
            {
                if(quantfolhas <= 0)
                {
                    Console.WriteLine("\n Troque de caderno");
                }
                else
                {
                    Console.WriteLine("\n Abra o caderno");
                }
                                   
            }
        }
        public void Escrevernocaderno()
        {
            if (aberto == true)
            {
                if (quantfolhas <= 0)
                {
                    Console.WriteLine("\n Troque de caderno");
                }
                else
                {
                    Console.WriteLine("\n Escreva no caderno");
                }

            }
            else
            {
                Console.WriteLine("\n Abra o caderno para escrever");
            }
        }
        public void Pintar()
        {
            if (aberto == true)
            {
                if (quantfolhas <= 0)
                {
                    Console.WriteLine("\n Troque de caderno");
                }
                else
                {
                    Console.WriteLine("\n Começe a desenhar");
                }

            }
            else
            {
                Console.WriteLine("\n Abra o caderno para desenhar");
            }
        }
    }
}
