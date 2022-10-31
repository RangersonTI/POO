using System;
using System.Collections.Generic;
using System.Text;

namespace Material_Escolar
{
    class Caneta
    {
        private string Cor;
        private double Tamanho;
        private double Peso;
        private bool Tampada;
        private int PercentCarga;
        private string Marca;
        private string Material;
        private double Ponta;
        private string tipoPonta;
        private bool caida;
        private bool estourada;

        public string GetCor()
        {
            return this.Cor;
        }
        public void SetCor(string C)
        {
            this.Cor = C;
        }

        public double GetTamanho()
        {
            return this.Tamanho;
        }
        public void SetTamanho(double T)
        {
            this.Tamanho = T;
        }

        public double GetPeso()
        {
            return this.Peso;
        }
        public void SetPeso(double P)
        {
            this.Peso = P;
        }

        public bool GetTampada()
        {
            return this.Tampada;
        }
        public void SetTampada(bool Tam)
        {
            this.Tampada = Tam;
        }
        
        public int GetPercentCarga()
        {
            return this.PercentCarga;
        }
        public void SetPercentCarga(int Pc)
        {
            this.PercentCarga = Pc;
        }

        public string GetMarca()
        {
            return this.Marca;
        }
        public void SetMarca(string M)
        {
            this.Marca = M;
        }
        public string GetMaterial()
        {
            return this.Material;
        }
        public void SetMaterial(string Mat)
        {
            this.Material = Mat;
        }

        public double GetPonta()
        {
            return this.Ponta;
        }
        public void SetPonta(double Ponta)
        {
            this.Ponta = Ponta;
        }

        public string GettipoPonta()
        {
            return this.tipoPonta;
        }
        public void SettipoPonta(string tP)
        {
            this.tipoPonta = tP;
        }

        public bool Getcaida()
        {
            return this.caida;
        }
        public void Setcaida(bool caida)
        {
            this.caida = caida;
        }

        public bool Getestourada()
        {
            return this.estourada;
        }
        public void Setestourada(bool estourada)
        {
            this.estourada = estourada;
        }


        public void Escrever()
        {
            if (caida == true)
            {
                Console.WriteLine("\n Pegue a caneta ");
            }
            else
            {
                if (estourada == true)
                {
                    Console.WriteLine("\n Troque de caneta");
                }
                else
                {
                    if (Tampada == true)
                    {
                        Console.WriteLine("\n Não é possível escrever, pois a caneta está tampada. Por favor destampe.");
                    }
                    else
                    {
                        if (PercentCarga == 0)
                        {
                            Console.WriteLine("\n Caneta sem carga. Troque-a.");
                        }
                        else
                        {
                            Console.WriteLine("\n Começe a escrever");
                        }

                    }
                }
            }
        }

        public void Destampar()
        {
            if (Tampada == true)
            {
                Console.WriteLine("\n Destampe a caneta");
            }
            else
            {
                Console.WriteLine("\n A caneta ja está destampada. Não é necessário. ");
            }
        }

        public void Tampar()
        {
            if (Tampada == true)
            {
                Console.WriteLine("\n A caneta ja está tampada. Não é necessário.");
            }
            else
            {
                Console.WriteLine("\n Tampe a caneta");
            }
        }

        public void Cair()
        {
            if (caida == true)
            {
                Console.WriteLine("\n A caneta está caida. Pegue a canete");
            }
            else
            {
                Console.WriteLine("\n A caneta não esta caída");
            }

        }

        public void Status()
        {

            Console.WriteLine();
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Tamanho: " + Tamanho);
            Console.WriteLine("Peso: " + Peso);
            Console.WriteLine("Tampada: " + Tampada);
            Console.WriteLine("Porc. Carga: " + PercentCarga);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Materia: " + Material);
            Console.WriteLine("Ponta: " + Ponta);
            Console.WriteLine("Tipo de ponta: " + tipoPonta);
            Console.WriteLine("A caneta está caída? " + caida);
            Console.WriteLine("A caneta está estourada? " + estourada);
        }
    }
}