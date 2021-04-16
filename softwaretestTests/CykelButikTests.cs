using NUnit.Framework;
using softwaretest;
using System;
using System.Collections.Generic;
using System.Text;

namespace softwaretest.Tests
{
    [TestFixture()]
    public class CykelButikTests
    {
        [Test]
        public void CykelConstructorSætterVariabler()
        {
            var nyCykel = new Cykel("RacerCykel", "blå", 2, 11000.00);
            Assert.That(nyCykel.navn == "RacerCykel");
            Assert.That(nyCykel.farve == "blå");
            Assert.That(nyCykel.antal_hjul == 2);
            Assert.That(nyCykel.pris == 11000.00);
        }
        [Test]
        public void NyCykelFarveTest()
        {
            var nyCykel = new Cykel("Dame Cykel", "sårt", 2, 3999.95);
            nyCykel.opdaterCykelFarve("sort");
            Assert.That(nyCykel.farve == "sort");
        }

        [Test]
        public void TilføjCykelTest()
        {
            var nyCykel = new Cykel("Trehjulet Cykel", "grøn", 3, 1499.95);
            var nyCykelButik = new CykelButik();
            nyCykelButik.tilføjCykel(nyCykel);
            Assert.That(nyCykelButik.listeAfCykler[0] == nyCykel);
        }

        [Test]
        public void HentCyklerTest()
        {
            var nyCykelButik = new CykelButik();
            var nyCykel = new Cykel("Et hjulet Cykel", "sølv", 1, 999.95);
            nyCykelButik.tilføjCykel(nyCykel);
            int antalCyklerIListe = nyCykelButik.hentCykler().Length;
            Assert.That(nyCykelButik.hentCykler().Length == antalCyklerIListe);
        }

        [Test]
        public void FjernCykelTest()
        {
            var nyCykel = new Cykel("Væltepeter", "grøn", 2, 3999.95);
            var nyCykelButik = new CykelButik();
            nyCykelButik.tilføjCykel(nyCykel);
            Assert.That(nyCykelButik.listeAfCykler.Count == 1);
            nyCykelButik.fjernCykel(nyCykel);
            Assert.That(nyCykelButik.listeAfCykler.Count == 0);
        }
    }
}