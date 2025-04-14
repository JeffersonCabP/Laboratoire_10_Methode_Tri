using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tri_Bulle;

namespace Algorithm_Tri
{
    internal class Tri_selection : ITrier
    {
        // Trouve le plus petit élément et la place au début
        public List<int> TrierListe(List<int> list)
        {
            var resultat = new List<int>(list);
            for (int i = 0; i < resultat.Count - 1; i++)
            {
                int minElement = i;
                for (int j = i + 1; j < resultat.Count; j++)
                {
                    if (resultat[j] < resultat[minElement])
                    {
                        minElement = j;
                    }
                }
                (resultat[i], resultat[minElement]) = (resultat[minElement], resultat[i]);
            }
            return resultat;
        }

    }
}
