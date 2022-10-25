using System;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;


     internal class Program
    {
        public static void Main(String[] args)
        {
            //Console.WriteLine(" Hello World");
            Caneta cbic = new Caneta(); //("Verde", 12, 5, true, 75, "Bic", "Acrílico", 0.4, "Esferiografica", false, false);
        cbic.Cor = "Verde";
        cbic.Tamanho = 12;
        cbic.Peso = 5;
        cbic.Tampada = true;
        cbic.PercentCarga = 75;
        cbic.Marca = "Bic";
        cbic.Material = "Acrílico";
        cbic.Ponta = 0.4;
        cbic.TipoPonta = "Esferiografica";
        cbic.caida = false;
        cbic.estourada = false;
        cbic.Exibicao();
        }
    }

