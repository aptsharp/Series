using Series.Interfaces;
using System;
using System.Collections.Generic;

namespace Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        void IRepositorio<Serie>.Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        void IRepositorio<Serie>.Excluir(int id)
        {
            listaSerie[id].Excluir();
            /*
             * todas as implementação devem ser usadas aqui referente a cada metodo
             * exemplo situacional: todas as vezes que excluir uma serie mandar um e-mail
             * essa metodologia de e-mail deve ser colocada aqui dentro do metodo
             * ou pode ser feito uma classe de negociso, já pensando nesse desenvolvimento 
            */
        }

        void IRepositorio<Serie>.Insere(Serie objeto)
        {
            listaSerie.Add(objeto); //apenas adiciona o objeto a lista
        }

        List<Serie> IRepositorio<Serie>.Lista()
        {
           return listaSerie;
        }

        int IRepositorio<Serie>.proximoId()
        {
            return listaSerie.Count;
            // com a coleção baseada em 0 o Count sempre vai estar +1 na frente
        }

        Serie IRepositorio<Serie>.RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}