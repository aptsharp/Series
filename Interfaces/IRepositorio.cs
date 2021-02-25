using System.Collections.Generic;
namespace Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Excluir(int id);
        void Atualiza(int id, T endidade);
        int proximoId();
        
    }
}