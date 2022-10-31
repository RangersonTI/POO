using System;
using System.Collections.Generic;
using System.Text;

namespace Material_Escolar
{
    class Borracha
    {
        private int porcenttamanho = 100;
        private string marca;
        private double tamanho;
        private string cor;
        private string forma;

        public Borracha(string M, string C, int T, string F)
        {
            this.marca = M;
            this.cor = C;
            this.tamanho = T;
            this.forma = F;

        }

        private void dimminuitamanho()
        {
            this.tamanho = this.tamanho - (this.tamanho * 0.04);
            this.porcenttamanho = this.porcenttamanho - 2;
        }

        public void Gasta()
        {
            if (porcenttamanho <= 10)
            {
                Console.WriteLine(" A borracha está gasta. Compre uma borracha");
                return;
            }
            Console.WriteLine(" A borracha está em boa condição de uso");

        }

        public void Apagar()
        {
            if (porcenttamanho <= 10)
            {
                Console.WriteLine(" A borracha está gasta. Compre uma borracha");
                return;
            }
            Console.WriteLine(" Você pode apagar");
            dimminuitamanho();
        }

        public void limpar()
        {
            if (porcenttamanho <= 10)
            {
                Console.WriteLine(" A borracha está gasta. Compre outra borracha");
                return;
            }
            Console.WriteLine(" A borracha em boa condição de uso");
            dimminuitamanho();
        }

        public void Status()
        {
            Console.WriteLine("\n Marca: " + marca);
            Console.WriteLine("\n Cor: " + cor);
            Console.WriteLine("\n Forma: " + forma);
            Console.WriteLine("\n Tamanho atual: " + tamanho + "cm");
            Console.WriteLine("\n % de borracha: " + porcenttamanho);
        }
    }
}
