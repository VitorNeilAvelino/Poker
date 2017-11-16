using System.Collections.Generic;

namespace Poker.Dominio
{
    public class Mesa
    {
        public List<Posicao> Posicoes { get; set; }

        public TipoJogo TipoJogo { get; set; }

        public Baralho Baralho { get; set; }

        public void Embaralhar()
        {
            
        }
    }
}