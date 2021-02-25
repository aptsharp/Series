using Series.Interfaces;
using System;
using System.Collections.Generic;

namespace Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        void IRepositorio<Serie>.Atualiza(int id, Serie endidade)
        {
            throw new NotImplementedException();
        }

        void IRepositorio<Serie>.Excluir(int id)
        {
            throw new NotImplementedException();
        }

        void IRepositorio<Serie>.Insere(Serie entidade)
        {
            throw new NotImplementedException();
        }

        List<Serie> IRepositorio<Serie>.Lista()
        {
            throw new NotImplementedException();
        }

        int IRepositorio<Serie>.proximoId()
        {
            throw new NotImplementedException();
        }

        Serie IRepositorio<Serie>.RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}