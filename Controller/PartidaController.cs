using CBF.Domain;
using CBF.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CBF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartidaController : ControllerBase
    {
        private PartidaService _partidaService = new PartidaService();
        [HttpPost("inserir")]
        public void Inserir(Partida partida)
        {
            _partidaService.Inserir(partida);
        }

        [HttpGet("listar")]
        public List<Partida> Listar()
        {
            return _partidaService.Listar();
        }
    }
}
