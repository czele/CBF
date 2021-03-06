﻿using CBF.Domain;
using CBF.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CBF.Service
{
    public class JogadorService
    {
        public JogadorRepository _jogadorRepository = new JogadorRepository();

        public List<Jogador> Listar()
        {
            return _jogadorRepository.Listar();
        }

        public void Inserir(Jogador jogador)
        {
            _jogadorRepository.Inserir(jogador);
        }

        public Jogador Obter(string Nome)
        {
            return _jogadorRepository.Obter(Nome);
        }
    }
}
