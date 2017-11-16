namespace Poker.Dominio
{
    public class Carta
    {
        public Carta(Naipe naipe, Face face)
        {
            Naipe = naipe;
            Face = face;
        }

        public Naipe Naipe { get; set; }
        public Face Face { get; set; }
    }
}