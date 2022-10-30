using System;

namespace MeuMaterialEscolar
{
    class Principal
    {
        static void Main(string[] args)
        {
            Apontador A = new Apontador();
            Lapis L = new Lapis();
            Caneta C = new Caneta();
            Borracha B = new Borracha("Mercur", "Verde", 7, "Lozango");
            Caderno E = new Caderno();


            C.SetCor("Verde");
            C.SetTamanho(14);
            C.SetPeso(30);
            C.SetTampada(true);
            C.SetPercentCarga(87);
            C.SetMarca("Bic");
            C.SetMaterial("Acrílico");
            C.SetPonta(3.7);
            C.SettipoPonta("Esferica");
            C.Setcaida(false);
            C.Setestourada(true);

            A.Setcego(false);
            A.Setguardado(false);
            A.Setenferrujado(false);
            A.Setcor("Amarelo");
            A.Setmarca("ApontME");
            A.Setforma("Retangulo");
            A.Settamanho(7);

            //A.Apontar();

            E.Setquantfolha(300);
            E.Setquantmateria(10);
            E.Setmarca(" Turma do Jandaia");
            E.Settipocapa(" Brochura");
            E.Setpauta(true);
            E.Setespiral(true);
            E.aberto = false;

            E.Arrancarfolha();
            E.Escrevernocaderno();
            E.Pintar();

            L.Setcor("Preto");
            L.Settipomaterial("Madeira");
            L.Setapontado(true);
            L.SetpercentGrafite(6);

            //Console.WriteLine("\n********Lápis********\n");
            //L.Pintar();
            //L.Escrever();

            //B.limpar();
            //B.Apagar();
            //B.Status();

        }
    }
}
