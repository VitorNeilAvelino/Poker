using System;

namespace Poker.Dominio
{
    public class Carta : IEquatable<Carta>
    {
        public Carta(Naipe naipe, Face face)
        {
            Naipe = naipe;
            Face = face;
        }

        public Naipe Naipe { get; set; }
        public Face Face { get; set; }

        public bool Equals(Carta other)
        {
            if (other == null)
            {
                return false;
            }

            return this.Naipe == other.Naipe && this.Face == other.Face;
        }
    }
}