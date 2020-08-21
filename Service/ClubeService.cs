using CBF.Domain;
using CBF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBF.Service
{
    public class ClubeService
    {
        public ClubeRepository _clubeRepository = new ClubeRepository();
        public Clube Obter(string nome)
        {
            return _clubeRepository.Obter(nome);
        }

        public Clube Obter(int id)
        {
            return _clubeRepository.Obter(id);
        }

        public List<Clube> Listar()
        {
            return _clubeRepository.Listar();
        }
    }
}
