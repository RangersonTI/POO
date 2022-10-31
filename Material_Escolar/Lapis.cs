using System;
using System.Collections.Generic;
using System.Text;

namespace Material_Escolar
{
    class Lapis
    {
        private string cor;
        private string tipomaterial;
        private bool apontado;
        private int percentGrafite;

        public string Getcor()
        {
            return this.cor;
        }
        public void Setcor(string C)
        {
            this.cor = C;
        }
        public string Gettipomaterial()
        {
            return this.tipomaterial;
        }
        public void Settipomaterial(string Tm)
        {
            this.tipomaterial = Tm;
        }

        public bool Getapontado()
        {
            return this.apontado;
        }
        public void Setapontado(bool A)
        {
            this.apontado = A;
        }

        public int GetpercentGrafite()
        {
            return this.percentGrafite;
        }
        public void SetpercentGrafite(int PG)
        {
            this.percentGrafite = PG;
        }

        public void QuebrarPonta()
        {
            if (percentGrafite < 15)
            {
                Console.WriteLine(" Compre outro lapis");
                return;
            }
            else
            {
                Console.WriteLine(" Aponte o lápis");
            }

            GastarGrafite(6);
        }

        public void Apontar()
        {
            if (percentGrafite < 15)
            {
                Console.WriteLine(" Compre outro lapis");
                return;
            }
            else
            {
                Console.WriteLine(" Aponte o lápis");
            }
            apontado = true;
        }

        private void GastarGrafite(int _per)
        {
            percentGrafite -= _per;

            if (percentGrafite < 0)
            {
                percentGrafite = 0;
            }
        }

        public void Escrever()
        {
            if (percentGrafite < 10)
            {
                Console.WriteLine(" Compre outro lapis");
                return;
            }
            if (!apontado)
            {
                Console.WriteLine(" Aponte o lapis");
            }
            Console.WriteLine(" Você pode escrever ");

        }

        public void Pintar()
        {
            if (percentGrafite < 10)
            {
                Console.WriteLine(" Compre outro lapis");
                return;
            }
            if (!apontado)
            {
                Console.WriteLine(" Aponte o lapis");
            }
            Console.WriteLine(" Começe a pintar ");
        }
    }
}
