using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tri_Bulle;

namespace Algorithm_Tri
{
    internal class MenuPrincipale
    {
        public static ITrier VotreChoix(int choix)
        {
            switch (choix)
            {
                case 1:
                    return new Tri_bulle();
                case 2:
                    return new Tri_insertion();
                 case 3:
                    return new Tri_selection();
                case 4:
                    return new Tri_rapide();
                case 5:
                    return new Tri_fusion();
                default:
                    Console.WriteLine("Choix invalide!");
                    return null;
            }
        }
        // public => Accessible partout
        // static => Appel sans créer d'objet de la classe
        // ITrier => Type de retour : Une instance d'une classe qui implémente cette Interface
        // VotreChoix => nom de la méthode



    }
}
