using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tri_Bulle;

namespace Algorithm_Tri
{
    internal class Tri_insertion : ITrier
    {
        public List<int> TrierListe(List<int> list)
        {
            var resultat = new List<int>(list);
            for (int i = 0; i < resultat.Count; i++)
            {
                int tempon = resultat[i];
                int j = i - 1;
                while ( j >= 0 && resultat[j] > tempon)
                {
                    resultat[j + 1] = resultat[j];
                    j--;
                }
                resultat[j + 1] = tempon;
            }
            return resultat;
        }



    }
}
