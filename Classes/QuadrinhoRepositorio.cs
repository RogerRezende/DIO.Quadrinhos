using System;
using System.Collections.Generic;
using DIO.Quadrinhos.Interfaces;

namespace DIO.Quadrinhos
{
    public class SerieRepositorio : IRepositorio<Quadrinho>
    {
        private List<Quadrinho> listaQuadrinho = new List<Quadrinho>();
        public void Atualiza(int id, Quadrinho entidade)
        {
            throw new NotImplementedException();
        }
        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }
        public void Insere(Quadrinho entidade)
        {
            throw new NotImplementedException();
        }
        public List<Quadrinho> Lista()
        {
            throw new NotImplementedException();
        }
        public int ProximoId()
        {
            throw new NotImplementedException();
        }
        public Quadrinho RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}