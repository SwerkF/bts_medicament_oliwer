﻿using System;

namespace AP4_GSB
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fin = 0;
            int qDoli = 0;
            int qIbup = 0;
            int qEffe = 0;
            int qSpas = 0;
            string c1 = "0";
            string c2  = "0";
            string c3  = "0";
            string c4  = "0";
            while(Fin != 1) {
            Fin = 0;
            c1 = "0";
            c2 = "0";
            c3 = "0";
            c4 = "0";
            Console.WriteLine("Bienvenue dans l'application");
            Console.WriteLine("____________________________");
            Console.WriteLine("Que voulez vous faire ?\n - AV = Ajouter un médicament en stock\n - VM = Vendre un médicament\n - VS Visualiser le stock des médicaments");
            string choixMen = Console.ReadLine();
            if(choixMen == "AV") {
            while(Fin != 2) {

            if(c1 == "1" && c2 == "1" && c3 == "1" && c4 == "1") {
                Console.WriteLine("Tous les médicaments on été entrés");
                Console.WriteLine("Doliprane = " + qDoli + "\nIbuprofene = " + qIbup + "\nEfferalgan = " + qEffe + "\nSpasfan = " + qSpas);
                Fin = 2;
            } else {
            Console.WriteLine("Quel médicament souhaitez vous entrer ?\n D = Doliprane\n I = Ibuprofene\n E = Efferalgan\n S = Spasfan");
            string choixMed = Console.ReadLine();
            if(choixMed == "D" && c1 == "1") {
                    Console.WriteLine("Ce médicament à déjà été saisi");
                    Console.WriteLine("Quel médicament souhaitez vous entrer ?\n D = Doliprane\n I = Ibuprofene\n E = Efferalgan\n S = Spasfan");
                    choixMed = Console.ReadLine();
            } else if(choixMed == "I" && c2 == "1") {
                    Console.WriteLine("Ce médicament à déjà été saisi");
                    Console.WriteLine("Quel médicament souhaitez vous entrer ?\n D = Doliprane\n I = Ibuprofene\n E = Efferalgan\n S = Spasfan");
                    choixMed = Console.ReadLine();
            } else if(choixMed == "E" && c3 == "1") {
                    Console.WriteLine("Ce médicament à déjà été saisi");
                    Console.WriteLine("Quel médicament souhaitez vous entrer ?\n D = Doliprane\n I = Ibuprofene\n E = Efferalgan\n S = Spasfan");
                    choixMed = Console.ReadLine();
            } else if(choixMed == "S" && c4 == "1") {
                    Console.WriteLine("Ce médicament à déjà été saisi");
                    Console.WriteLine("Quel médicament souhaitez vous entrer ?\n D = Doliprane\n I = Ibuprofene\n E = Efferalgan\n S = Spasfan");
                    choixMed = Console.ReadLine();
            } else {
                while(choixMed != "D" && choixMed != "I" && choixMed != "E" && choixMed != "S" ) {
                Console.WriteLine("Quel médicament souhaitez vous entrer ?\n D = Doliprane\n I = Ibuprofene\n E = Efferalgan\n S = Spasfan");
                choixMed = Console.ReadLine();
            }


            Console.WriteLine("Quel est la quantité du médicament ?");
            string quantite = Console.ReadLine();
            int error1 = 1;
            while(error1 == 1) {
                Char value = ',';
                Char value2 = '.';
                if(quantite.Contains(value) || quantite.Contains(value2)) {
                    Console.WriteLine("Le nombre doit être un entier");
                    quantite = Console.ReadLine();
                } else {
                    error1 = 0;
                }
            }
            int quantite2 = int.Parse(quantite);
            while(quantite2 < 0) {
                Console.WriteLine("Valeure incorrecte. Quel est la quantité du médicament ?");
                quantite = Console.ReadLine();
            }

            if(choixMed == "D") {
                qDoli = qDoli + quantite2;
                c1 = "1";
                Console.WriteLine("Quantité ajouté.");
            }
            else if(choixMed == "I") {
                qIbup = qIbup + quantite2;
                c2 = "1";
                Console.WriteLine("Quantité ajouté.");
            }
            else if(choixMed == "E") {
                qEffe = qEffe + quantite2;
                c3 = "1";
                Console.WriteLine("Quantité ajouté.");
            }
            else if(choixMed == "S") {
                qSpas = qSpas + quantite2;
                c4 = "1";
                Console.WriteLine("Quantité ajouté.");
            }
            Console.WriteLine("Voulez vous saisir un autre médicament ?");
            choixMen = "";
            choixMen = Console.ReadLine();
            while (choixMen != "Oui" && choixMen != "Non") {
                Console.WriteLine("Voulez vous saisir un autre médicament ?");
                choixMen = Console.ReadLine();
            }
            if(choixMen == "Oui") {
                Fin = 3;
            } else if(choixMen == "Non") {
                Fin = 2;
            }
            }
            }
            }

            } else if(choixMen == "VM") {
                Console.WriteLine("Quel médicament souhaitez vous vendre ?\n D = Doliprane\n I = Ibuprofene\n E = Efferalgan\n S = Spasfan");
                string choixMed = Console.ReadLine();
                 while(choixMed != "D" && choixMed != "I" && choixMed != "E" && choixMed != "S" ) {
                Console.WriteLine("Quel médicament souhaitez vous vendre ?\n D = Doliprane\n I = Ibuprofene\n E = Efferalgan\n S = Spasfan");
                choixMed = Console.ReadLine();
            }
            Console.WriteLine("Quel est la quantité du médicament ?");
            string quantite = Console.ReadLine();
            int error1 = 1;
            while(error1 == 1) {
                Char value = ',';
                Char value2 = '.';
                if(quantite.Contains(value) || quantite.Contains(value2)) {
                    Console.WriteLine("Le nombre doit être un entier");
                    quantite = Console.ReadLine();
                } else {
                    error1 = 0;
                }
            }
            int quantite2 = int.Parse(quantite);
            while(quantite2 < 0) {
                Console.WriteLine("Valeure incorrecte. Quel est la quantité du médicament ?");
                quantite = Console.ReadLine();
            }
            error1 = 1;
            while(error1 != 1) {
                if(choixMed == "D" && qDoli > quantite2) {
                    Console.WriteLine("Quantité supérieur au stock");
                    quantite2 = int.Parse(Console.ReadLine());
                } else if(choixMed == "I" && qIbup > quantite2) {
                    Console.WriteLine("Quantité supérieur au stock");
                    quantite2 = int.Parse(Console.ReadLine());
                } else if(choixMed == "E" && qEffe > quantite2) {
                    Console.WriteLine("Quantité supérieur au stock");
                    quantite2 = int.Parse(Console.ReadLine());
                } else if(choixMed == "S" && qSpas > quantite2) {
                    Console.WriteLine("Quantité supérieur au stock");
                    quantite2 = int.Parse(Console.ReadLine());
                } else {
                    error1 = 0;
                }

            }
            Console.WriteLine("Quelle est le prix du médicament ?");
            double prix = int.Parse(Console.ReadLine());
            string choixMedLong = "";
            if(choixMed == "D") {
                    choixMedLong = "Doliprane";
                } else if(choixMed == "I") {
                    choixMedLong = "Ibuprofene";
                } else if(choixMed == "E") {
                    choixMedLong = "Efferalgan";
                } else if(choixMed == "S") {
                    choixMedLong = "Spasfan";

                }
            Console.WriteLine("Vous avez choisi "+ quantite2 + choixMedLong + " a vendre au prix de " + prix + " EUROS/unité");  
            } else if(choixMen == "VS") {
                Console.WriteLine("Stock :");
                Console.WriteLine("Doliprane = " + qDoli + "\nIbuprofene = " + qIbup + "\nEfferalgan = " + qEffe + "\nSpasfan = " + qSpas);
            }

        }
        }
    }
}
