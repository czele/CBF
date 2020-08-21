using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBF.Domain
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ClubeId { get; set; }
        public int PosicaoId { get; set; }
    }
}
