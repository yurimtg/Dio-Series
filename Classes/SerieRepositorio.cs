using System;
using System.Collections.Generic;
using Dio.series.Interfaces;

namespace Dio.series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualizar(int id, Serie objeto)
        {
            listaSerie[id]= objeto;
        }

        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}