using Algorithm_Tri;

namespace Tri_Bulle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer les données de la liste (EX: 8 3 7 1 43 78 45)");
            var input = Console.ReadLine();

            var data = input.Split(' ').Select(int.Parse).ToList();
            // input.Split(' ') => sous-chaine, en utilisant l'espace comme delimiteur
            // On obtient une sous-chaine ["8", "3", "7",...]
            // Select(int.Parse) => convertir une chaine de caractère en entier. Le faire sur chaque élément ex: //8 => "8"
            // ToList() => Convertir la séquence d'entiers en une liste d'entier; [8, 3, 7,...]

            Console.WriteLine("\nChoisissez un algorithme de tri");
            Console.WriteLine("1, Tri Bulle");
            Console.WriteLine("2, Tri Insertion");
            Console.WriteLine("3, Tri Selection");
            Console.WriteLine("4, Tri Rapide");
            Console.WriteLine("5, Tri Fusion");

            Console.Write("Votre choix (1-5) ? :");
            int choix = int.Parse(Console.ReadLine());

            ITrier algorithme = MenuPrincipale.VotreChoix(choix);
            List<int> ListeTrier = algorithme.TrierListe(data);

            Console.WriteLine("Liste Trié :");
            Console.WriteLine(string.Join(" ", ListeTrier));
        }
    }
}
