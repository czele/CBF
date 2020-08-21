using CBF.Domain;
using CBF.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBF.Controller
{
    [ApiController]
    [Route("controller")]
    public class JogadorController : ControllerBase
    {
        private JogadorService _jogadorService = new JogadorService();
        [HttpPost("inserir")]
        public void Inserir(Jogador jogador)
        {
            _jogadorService.Inserir(jogador);
        }

        [HttpGet("listar")]
        public List<Jogador> Listar()
        {
            return _jogadorService.Listar();
        }
    } 
}
