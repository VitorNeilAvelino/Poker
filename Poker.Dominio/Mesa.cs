using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Dominio
{
    public class Mesa
    {
        public Mesa()
        {
            Monte = new Stack<Carta>();
            Embaralhar();
        }

        public List<Posicao> Posicoes { get; set; }

        public TipoJogo TipoJogo { get; set; }

        public Stack<Carta> Monte { get; set; }

        private void Embaralhar()
        {
            var aleatorio = new Random(Guid.NewGuid().GetHashCode());
            var sequencia = Enumerable.Range(0, 52).ToArray();
            var embaralhado = sequencia.OrderBy(s => aleatorio.NextDouble());
            var baralho = new Baralho();

            foreach (var numero in embaralhado)
            {
                Monte.Push(baralho.Cartas[numero]);
            }
        }
    }
}