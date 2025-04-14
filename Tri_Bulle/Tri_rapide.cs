using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tri_Bulle;

namespace Algorithm_Tri
{
    internal class Tri_rapide : ITrier
    {
        public List<int> TrierListe(List<int> list)
        {
            var resultat = new List<int>(list);
            TrierRapide(resultat, 0, resultat.Count - 1);
            return resultat;
        }

        private void TrierRapide(List<int> list, int gauche, int droite)
        {
            if (gauche  < droite)
            {
                int pivot = Partition(list, gauche, droite);
                TrierRapide(list, gauche, pivot - 1);
                TrierRapide(list, pivot - 1,droite);
            }
        }

        private int Partition(List<int> list, int gauche, int droite)
        {
            
        }
    }
}
