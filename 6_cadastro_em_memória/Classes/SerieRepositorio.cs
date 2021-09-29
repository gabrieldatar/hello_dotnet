using System;
using System.Collections.Generic;
using _6_cadastro_em_memória.Interfaces;

namespace _6_cadastro_em_memória
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        
        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
            
        }

        public void Inserir(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public void Excluir(int id)
        {
            //Remove e realoca as posições no vetor
            //listaSerie.RemoveAt(id);
            listaSerie[id].setExcluir();
        }

        public void Atualizar(int id, Serie objeto)
        {
            listaSerie[id]=objeto;
        }
        
        public int ProximoId()
        {
            return listaSerie.Count;
        }
    }
}