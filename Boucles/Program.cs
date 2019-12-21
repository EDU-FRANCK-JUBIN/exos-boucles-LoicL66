using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix = -1;

            while (choix != 0) {
            Console.WriteLine("=-=-=-=-= Exercices sur les boucles =-=-=-=-=");
            Console.WriteLine("1 : Multiples de 2 (0 à 20)");
            Console.WriteLine("2 : Somme jusqu'à n");
            Console.WriteLine("3 : Calcul de moyenne de valeurs");
            Console.WriteLine("4 : Somme des entiers entre x et y");
            Console.WriteLine("5 : Calcul de moyenne sur une liste");
            Console.WriteLine("6 : Entiers communs à deux listes");
            Console.WriteLine("0 : Quitter");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Quel exercice voulez vous tester ?");
            choix = Int32.Parse(Console.ReadLine());


                switch (choix)
                {
                    case 0:
                        Console.WriteLine("Merci d'avoir testé mes exercices, bonne fêtes !");
                        Console.ReadLine();
                        break;
                    case 1:
                        Console.WriteLine("Exo 1 : Multiples de 2 (0 à 20)");
                        for (int i = 0; i <= 20; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Exo 2 : Somme jusqu'à n");
                        Console.Write("Entrez un nombre :");
                        int nombre = Int32.Parse(Console.ReadLine());
                        int sommeNombres = nombre;
                        for (int i = 0; i < nombre; i++)
                        {
                            sommeNombres += i;
                        }
                        Console.Write("Le total est de : " + sommeNombres);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Exo 3 : Calcul de moyenne");
                        Console.Write("Sur combien de nombre voulez vous etablir un moyenne ? :");
                        int[] valeurs = new int[Int32.Parse(Console.ReadLine())];
                        int sommeValeurs = 0;

                        for (int i = 0; i < valeurs.Length; i++)
                        {
                            Console.Write("Renseignez le nombre n°" + (i + 1) + " :");
                            valeurs[i] = Int32.Parse(Console.ReadLine());
                        }

                        for (int i = 0; i < valeurs.Length; i++)
                        {
                            sommeValeurs += valeurs[i];
                        }
                        int moyenneValeurs = sommeValeurs / valeurs.Length; 
                        //on pouvait aussi faire un valeurs.Average()

                        Console.Write("La moyenne est de : " + moyenneValeurs);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Exo 4 : Somme des entiers entre x et y");
                        Console.Write("Renseignez le premier nombre :");
                        int nombre1 = Int32.Parse(Console.ReadLine());

                        Console.Write("Renseignez le deuxième nombre :");
                        int nombre2 = Int32.Parse(Console.ReadLine());

                        int moyenneEntiers = CalculSommeEntiers(nombre1, nombre2);
                        Console.WriteLine("La moyenne des entiers compris entre " + nombre1 + " et " + nombre2 + " et de " + moyenneEntiers);

                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Exo 5 : Calcul de moyenne sur une liste");
                        Console.Write("Combien de flotant voulez vous ajouter à la liste ? :");
                        int tailleListe = Int32.Parse(Console.ReadLine());
                        var liste = new List<double>();

                        for (int i = 0; i < tailleListe; i++)
                        {
                            Console.Write("Renseignez le flotant n°" + (i + 1) + " :");
                            liste.Add(Double.Parse(Console.ReadLine()));
                        }

                        var moyenneListe = CalculMoyenneListe(liste);
                        Console.WriteLine("La moyenne des flotant que vous avez renseignés est de " + moyenneListe);
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Exo 6 : Construction de listes et entiers communs");
                        List<int> multiplesDeTrois = ObtenirMultiples(3);
                        List<int> multiplesDeCinq = ObtenirMultiples(5);
                        List<int> entierscommuns = TrouverEntiersCommuns(multiplesDeCinq, multiplesDeTrois);

                        /**
                        * Petit doute sur l'énnoncé :
                        * faut il prendre en compte le fait que l'entier commun soit dans les deux listes pour le calcul de la somme ?
                        * Soit 15 + 15 + 30 + 30 + 45 + 45... OU seulement 15 + 30 + 45...
                        * Selon quoi le résultat sera 315 OU 630
                        * J'ai fais le choix de la deuxieme solution => somme = 315
                        **/
                        var sommeEntiers = 0;
                        entierscommuns.ForEach(entier => { sommeEntiers += entier;
                            Console.WriteLine(entier);
                        });

                        Console.Write("La moyenne est de : " + sommeEntiers); 
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Exercice inconnu, pouvez vous préciser à nouveau votre choix ?");
                        break;

                }

            };

        }

        public static int CalculSommeEntiers(int x, int y)
        {
            int moyenne = 0;

            for(int i = x; i <= y; i++)
            {
                moyenne += i;
            }

            return moyenne;
        }

        public static double CalculMoyenneListe(List<double> liste)
        {
            double moyenne = liste.Average();
            return moyenne;
        }

        public static List<int> ObtenirMultiples(int multiplicateur)
        {
            var multiples = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % multiplicateur == 0)
                {
                    multiples.Add(i);
                    Console.WriteLine(i);
                }
            }

            return multiples;
        }

        public static List<int> TrouverEntiersCommuns(List<int> liste1, List<int> liste2)
        {
            var entiersCommuns = new List<int>();
            foreach(int entier in liste1)
            {
                if (liste2.Contains(entier))
                {
                    entiersCommuns.Add(entier);
                    Console.WriteLine(entier);
                }
            }

            return entiersCommuns;
        }
    }
}
