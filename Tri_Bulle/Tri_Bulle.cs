using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_Bulle
{
    internal class Tri_bulle : ITrier
    {
        // Compare les éléments adjacents et les échange s'ils sont dans le mauvais odre

        public List<int> TrierListe(List<int> list)
        {
            var resultat = new List<int>(list); // Passage de la liste venue en paramètre
            for (int i = 0; i < resultat.Count - 1; i++)
            {
                for (int j = 0; j < resultat.Count - i - 1; j++)
                {
                    if (resultat[j] > resultat[j + 1])
                    {
                        (resultat[j], resultat[j + 1]) = (resultat[j + 1], resultat[j]);
                        // Affectation en tuple (affecté plusieurs valeurs en même temps)

                        // int temp = resultat[j]
                        // resultat[j] = resultat[j + 1];
                        // resultat[j + 1] = temp;
                    }
                }
            }
            return resultat;
        }


    }
}
