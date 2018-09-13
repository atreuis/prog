using System;

namespace labo1davidbou
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = ("nom");
            Random rng = new Random();
            int colossus = rng.Next(1, 101);


            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Bienvenue cher joueur dans Stealing A The Voice Chair,veuillez rentrer votre nom");
            nom = Convert.ToString(Console.ReadLine());
            Console.WriteLine("D'accord " + nom + ", comment voulez-vous arriver? Par le service irréprochable de ce cher Dopinder ou par l'avion de X-Force  même s'il y a un plus grand facteur vent que la dernière fois? veuillez rentrer 1 ou 2 pour tout vos choix");

            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Vous arrivez sain et sauf graçe au magnifique service de votre ami indien préféré");
            }
            else
            {
                Console.WriteLine("Bravo, vous êtes arrivé à 10 kilomètres de votre destination. Vous appellez Dopinder et arrivez 5 minutes en retard");
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Vous êtes maintenant caché derrère une caisse du studio et voyez un garde armé. Comment voulez-vous le rendre «silencieux» ? Avec vos Katanas de la mort qui tue (1) ou bien vos Desert Eagle 50 AE.....sans silencieux bien sur....(2)");

            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Pour je ne sais quelle raison, l'avoir transformé en viande hachée a déclenché l'alarme et maintenant vous êtes entouré de 50 aurte gardes autant et d'autre mieux armé avec, au je ne sais pas moi....des lances-roquettes. Maintenant,    comment voulez-vous les disposer? Avec vos deagles(1) ou bien vos katanas couvert de l'ADN du premier garde(2)?");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Vu que Tout le monde est «hors d'état de nuire», vous voyez que vous avez deux options pour vous rendre au lieu de tournage, sois vous trouver votre Spider-Man intérieur et que vous vous dandinez dans les conduits de ventilations (1), ou bien............");
                Console.ReadKey();
                Console.WriteLine("....vous courez dans les couloirs en criant «JE VAIS VOLER UNE CHAISE DE THE VOICE, JE VAIS VOLER UNE CHAISE DE THE VOICE...»(2) ");

                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Bravo,vous avez nettoyer la ventillation du studio, en remuant plus de 60 ans de poussière");
                }
                else
                {
                    Console.WriteLine("Vous crier tellement fort que vous allez avoir un mal de gorge pendant au moins trois semaines");
                }

                Console.WriteLine("Vous avez maintenant la chaise en vue, elle de Miley Cirus en plus....mais il y a quelqu'un qui vous attend dans celle de Blake Sheldon, C'EST COLOSSUS!!!!!!!! Mais qu'est qu'il veut?");
                Console.ReadKey();
                Console.Clear();

                if (colossus <= 5)
                {
                    Console.WriteLine("Comme vous l'avez suspecter il est ici pour vous arrêter et vu que vous avez un petit crush sur lui, vous vous laisser menotter et ramener au manoir des X-mens ");
                    Console.WriteLine("Fin de la parite, veuillez réessayer.");
                }
                else
                {
                    Console.WriteLine("Bizzarment, votre ami de métal vous aide à voler la chaise de Hannah Montana");
                    Console.WriteLine("Bravo, vous avez réussi à voler une chaise de The Voice, maintenant allez la transformer un magnifique trone, vous l'avez mérité.");
                }
            }
            else
            {
                Console.WriteLine("Vous l'avez tellement criblé de balles qu'il y a plus de trous que de la chair. En plus, il semblerais que cela ne semble pas avoir déclenché l'alarme");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Vu que cela n'a rien déclenché, comment voulez-vous infiltrer le studio? En vous prenant pour Tom Cruise en chantant le thème de Mission Impossible dans  le système de ventilation(1) ou bien.........");
                Console.WriteLine("en criant «JE SUIS UNE MAGNIFIQUE LICORNE DANS UN CHAMPS DE DE MAIS ARC-EN-CIEL» dans les couloirs du studio (2)");

                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Vous pensez être le plus badass des super-héros mais en réalité vous êtes qu'un homme dans un costume moulant qui chante Mission Impossible dans 60 ans de poussière, mais vous arrivez à destination");

                }
                else
                {
                    Console.WriteLine("Pour aucunne raison, personne vous a entendu faire le moron et vous arrivez à destination sain et sauf");
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Vous la voyer.....elle est la ......");
                Console.WriteLine("devant vos yeux....");
                Console.WriteLine("vous la sentez d'ici.....");
                Console.WriteLine("LA CHAISE DE MILEY CIRUS!!!!!!!!!");
                Console.WriteLine("mais il y a quelqu'un dedans......");
                Console.WriteLine("COLOSSUS!?!?!?! MAIS QU'EST-CE QUE CE GROS TAS DE MÉTAL VEUT!?!?!?!?");
                Console.ReadKey();
                Console.Clear();

                if (colossus <= 5)
                {
                    Console.WriteLine("bizzarrement, il veut vous aider à la voler?!?!");
                    Console.WriteLine("Bravo vous avez réussi, maintenant allez vous déguiser en Hannah Montana en contenplant vos magnifique chaise");
                }

                else
                {
                    Console.WriteLine("Comme vous le suspectez, il est venu vous arrêter");
                    Console.WriteLine("Fin de la partie, veuillez recommencer");
                }


            }


            Console.ReadKey();
        }
    }
}
