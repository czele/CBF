using CBF.Domain;
using CBF.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClubeController : ControllerBase
    {
        private ClubeService _clubeService = new ClubeService();
        [HttpGet("obterByNome")]
        public Clube Obter(string nome)
        {
            return _clubeService.Obter(nome);
        }

        [HttpGet("obter")]
        public Clube Obter(int id)
        {
            return _clubeService.Obter(id);
        }

        [HttpGet("listar")]
        public List<Clube> Listar()
        {
            return _clubeService.Listar();
        }
    }
}
