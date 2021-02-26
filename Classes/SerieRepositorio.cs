using Series.Interfaces;
using System;
using System.Collections.Generic;

namespace Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
            /*
             * todas as implementação devem ser usadas aqui referente a cada metodo
             * exemplo situacional: todas as vezes que excluir uma serie mandar um e-mail
             * essa metodologia de e-mail deve ser colocada aqui dentro do metodo
             * ou pode ser feito uma classe de negociso, já pensando nesse desenvolvimento 
            */
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto); //apenas adiciona o objeto a lista
        }

        public List<Serie> Lista()
		{
			return listaSerie;
		}
        
        public int proximoId()
        {
            return listaSerie.Count;
            // com a coleção baseada em 0 o Count sempre vai estar +1 na frente
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}