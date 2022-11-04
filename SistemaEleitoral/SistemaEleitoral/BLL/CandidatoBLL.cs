using DAL;
using Models;
using System;

namespace BLL
{
    public class CandidatoBLL
    {
        public void Inserir(Candidato _candidato)
        {
            if (_candidato.Getnome().Length <= 2)
            {
                throw new Exception("Nome do eleitor deve ter mais de 2 caracteres.");
            }

            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Inserir(_candidato);
        }

        public void Excluir(Candidato _candidato)
        {
            if (_candidato.Getnome().Length <= 2)
            {
                throw new Exception("Nome do eleitor deve ter mais de 2 caracteres.");
            }
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Excluir(_candidato);
        }

        public void Alterar(Candidato _candidato)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Alterar(_candidato);
        }

        public List<Eleitor> Buscar(string _titulo)
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
            return eleitorDAL.Buscar(_titulo);
        }
    }
}