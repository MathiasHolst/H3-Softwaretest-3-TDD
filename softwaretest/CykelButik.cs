 using System;
using System.Collections.Generic;
using System.Text;

namespace softwaretest
{
    public class Cykel
    {
        public string navn;
        public string farve;
        public int antal_hjul;
        public double pris;

        public Cykel(string navn, string farve, int antal_hjul, double pris)
        {
            this.navn = navn;
            this.farve = farve;
            this.antal_hjul = antal_hjul;
            this.pris = pris;
        }

        public void opdaterCykelFarve(string farve)
        {
            this.farve = farve;
        }

    }
    public class CykelButik
    {
        public string navn;
        public List<Cykel> listeAfCykler = new List<Cykel>();

        public void tilføjCykel(Cykel cykel)
        {
            listeAfCykler.Add(cykel);
        }
        public Cykel[] hentCykler()
        {
            Cykel[] testCykelArray = new Cykel[listeAfCykler.Count];

            for(int i = 0; i < testCykelArray.Length; i++)
            {
                testCykelArray[i] = listeAfCykler[i];
            }
            return testCykelArray;
        }

        public void fjernCykel(Cykel cykel)
        {
            listeAfCykler.Remove(cykel);
        }
    }
}
