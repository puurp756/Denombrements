using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Calcule la factorielle d'un nombre.
        /// </summary>
        /// <param name="subsetSize">Le nombre dont on veut calculer la factorielle.</param>
        /// <returns>Le résultat de la factorielle de subsetSize (subsetSize!).</returns>
        static long CalculR(int subsetSize)
        {
            long factorialResult = 1;
            for (int k = 1; k <= subsetSize; k++)
                factorialResult *= k;
            return factorialResult;


        }

        static long CalculR2(int subsetSize, int t)
        {
            long factorialResult = 1;
            for (int k = (t - subsetSize + 1); k <= t; k++)
                factorialResult *= k;
            return factorialResult;

        }

        static void Main(string[] args)
        {
            //Boucle les saisies tant que la variable c est different de 0 et permer de lancer le jeu.

            int c = 1;
            while (c != 0) 
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());


                //Differentes conditions afin de s'assurer que chaque saisie execute un bloc de code qui lui est propre.

                //Recommencement de la boucle si saisie = 4 ou supérieur.
                if (c >= 4)
                {
                    Console.WriteLine("Mentionnez les bons nombres");
                    continue;
                }

                // sortie du programme si la saisie correspond à 0                                     
                else if (c == 0)
                {
                    Environment.Exit(0);
                }

                // Calcul la permutation via une fonction CalculR si saisie = 1
                else if (c == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = "); 
                    int subsetSize = int.Parse(Console.ReadLine());                                   
                    long factorialResult = CalculR(subsetSize);
                    Console.WriteLine(subsetSize + "! = " + factorialResult);
                    continue;
                }
                  //Calcul de l'arrangement via une fonction CalculR2 si saisie = 2
                    
                else if (c == 2)
                {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int t = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int subsetSize = int.Parse(Console.ReadLine());

                        long factorialResult = CalculR2(subsetSize, t);
                        Console.WriteLine("A(" + t + "/" + subsetSize + ") = " + factorialResult);
                        continue;
                }

                    //Calcul de la combinaison via les deux fonctions si la saisie = 3

                else if (c == 3)
                {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int totalElements = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int subsetSize = int.Parse(Console.ReadLine()); // saisir le nombre

                        // calcul de r1
                        long factorialResult1 = CalculR2(subsetSize, totalElements);
                        // calcul de r2
                        long factorialResult2 = CalculR(subsetSize);
                        Console.WriteLine("C(" + totalElements + "/" + subsetSize + ") = " + (factorialResult1 / factorialResult2));
                        continue;
                }
                
            }
            
        }
    }
}
