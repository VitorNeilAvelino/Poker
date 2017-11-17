using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Poker.Dominio.Tests
{
    [TestClass()]
    public class MesaTests
    {
        [TestMethod]
        public void MonteEstaEmbaralhadoTeste()
        {
            var mesa1 = new Mesa();
            var mesa2 = new Mesa();

            var cartasIguais = 0;

            for (int i = 0; i < 52; i++)
            {
                var carta1 = mesa1.Monte.Pop();
                var carta2 = mesa2.Monte.Pop();

                //Console.WriteLine($"{carta1.Face} de {carta1.Naipe}");
                //Console.WriteLine($"{carta2.Face} de {carta2.Naipe}");

                if (carta1.Equals(carta2))
                {
                    ++cartasIguais;
                }
            }

            Console.WriteLine(cartasIguais);

            if (cartasIguais >= 5)
            {
                Assert.Fail($"Encontradas {cartasIguais} cartas iguais.");
            }
        }

        [TestMethod()]
        public void MontePossuiTodasCartasTeste()
        {
            var mesa = new Mesa();

            Assert.IsTrue(mesa.Monte.Count == 52);

            var ouros = new List<Carta>();

            while (mesa.Monte.Count > 0)
            {
                var carta = mesa.Monte.Pop();

                if (carta.Naipe == Naipe.Ouros)
                {
                    ouros.Add(carta);
                }
            }

            Assert.IsTrue(ouros.Count == 13);

            //for (int i = 1; i <= 5; i++)
            //{
            //    var carta = mesa.Monte.Pop();

            //    Console.WriteLine($"{carta.Face} de {carta.Naipe}");
            //}
        }
    }
}