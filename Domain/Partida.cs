using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBF.Domain
{
    public class Partida
    {
        public int Id { get; set; }
        public int MandanteId { get; set; }
        public Clube Mandante { get; set; }
        public int GolsMandante { get; set; }
        public int VisitanteId { get; set; }
        public Clube Visitante { get; set; }
        public int GolsVisitante { get; set; }
    }
}
