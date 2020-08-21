using CBF.Domain;
using CBF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CBF.Service
{
    public class PartidaService
    {
        private PartidaRepository _partidaRepository = new PartidaRepository();
        private ClubeService _clubeService = new ClubeService();
        public void Inserir(Partida partida)
        {
            _partidaRepository.Inserir(partida);
        }

        public List<Partida> Listar()
        {
            var lista = _partidaRepository.Listar();

            foreach (var item in lista)
            {
                
                item.Mandante = _clubeService.Obter(item.MandanteId);
                item.Visitante = _clubeService.Obter(item.VisitanteId); 
            }
            return lista;

        }
    }

}
