using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tri_Bulle;

namespace Algorithm_Tri
{
    internal class Tri_fusion : ITrier
    {
        public List<int> TrierListe(List<int> liste)
        {
            if (liste.Count <= 1)
            {
                return new List<int>(liste);
            }

            // Dans le cas contraire

            int mid = liste.Count / 2;
            var gauche = TrierListe(liste.GetRange(0, mid)); // Retourne une sous liste à partir de l'indice (0) et d'une longueur (mid)

            //List<int> list = new List<int> { 8, 3, 5, 1, 9 };
            //int mid = 2;
            //liste.GetRange(0, mid); // Retourne la liste [8, 3] */

            var droite = TrierListe(liste.GetRange(mid, liste.Count - mid));

            return ListeFusionner(gauche, droite);





        }

        private List<int> ListeFusionner(List<int> gauche, List<int> droite)
        {
            var resultat = new List<int>();
            int i = 0; 
            int j = 0;

            while (i < gauche.Count && j < droite.Count)
            {
                if (gauche[i] <= droite[j])
                {
                    resultat.Add(gauche[i++]);
                }
                else
                {
                    resultat.Add(droite[j++]);
                }
            }
            resultat.AddRange(gauche.Skip(i)); // gauche.Skip(i) => méthode qui ignore les i premiers éléments de la liste et retourne le reste
            resultat.AddRange(droite.Skip(j)); // resultat.AddRange() => ajoute à la liste plusieurs éléments. Contrairement à Add() qui ajoute un seul éléments
            return resultat;
        }
    }
}
// gauche.Skip(i) => méthode qui ignore les i premiers éléments de la liste et retourne le reste
//List<int> list = new List<int> { 8, 3, 5, 1, 9 };
//int mid = 2;
// var reste = list.Skip(mid) => [5, 1, 9]
// resultat.AddRange() => ajoute à la liste plusieurs éléments. Contrairement à Add() qui ajoute un seul éléments