using System.Collections.Generic;

namespace _6_cadastro_em_memória.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Inserir(T objeto);

        void Excluir(int id);

        void Atualizar(int id, T objeto);

        int ProximoId();
         
    }
}