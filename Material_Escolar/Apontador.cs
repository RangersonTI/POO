using System;
using System.Collections.Generic;
using System.Text;

namespace Material_Escolar
{
    class Apontador
    {
        Lapis L = new Lapis();

        private bool cego;
        private bool guardado;
        private bool enferrujado;
        private string cor;
        private string marca;
        private string forma;
        private int tamanho;

        public bool Getcego()
        {
            return this.cego;
        }
        public void Setcego(bool C)
        {
            this.cego = C;
        }

        public bool Getguardado()
        {
            return this.guardado;
        }
        public void Setguardado(bool G)
        {
            this.guardado = G;
        }

        public bool Getenferrujado()
        {
            return this.enferrujado;
        }
        public void Setenferrujado(bool E)
        {
            this.enferrujado = E;
        }

        public string Getcor()
        {
            return this.cor;
        }
        public void Setcor(string C)
        {
            this.cor = C;
        }

        public string Getmarca()
        {
            return this.marca;
        }
        public void Setmarca(string M)
        {
            this.marca = M;
        }

        public string Getforma()
        {
            return this.forma;
        }
        public void Setforma(string F)
        {
            this.forma = F;
        }

        public int Gettamanho()
        {
            return this.tamanho;
        }
        public void Settamanho(int T)
        {
            this.tamanho = T;
        }

        public void Apontar()
        {
            if (guardado == true)
            {
                Console.WriteLine(" Pegue o apontador");
                return;
            }

            if (enferrujado == true)
            {
                Console.WriteLine(" Troque o seu apontador");
                return;
            }

            if (cego == true)
            {
                Console.WriteLine(" Troque o seu apontador");
                return;
            }

            L.QuebrarPonta();

        }
    }
}
