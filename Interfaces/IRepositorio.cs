using System.Collections.Generic;

namespace Dio.series.Interfaces
{
    public interface IRepositorio<T>
    {
            List<T> Lista();
            T RetornaPorId (int id);
            void Insere(T entidade);
            void Excluir(int id);
            void Atualizar(int id, T Entidade);
            int ProximoId();
    }
}