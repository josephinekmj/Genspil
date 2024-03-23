using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem.Methods
{
    public class CreateGame 
        //Denne klasse tillader indtasning af spiloplysninger i konsolvinduet.
    {
        public string id { get; set; } //Fields og properties, som er egenskaberne i objektet 'game' nedenfor
        public string title { get; set; }
        public string edition { get; set; }
        public string numberOfPlayers { get; set; }
        public string language { get;  set; }
        public string genre { get;  set; }
        public string condition { get; set; }
        public double price { get; set; }

        //Get bruges til at hente værdien af en variabel
        //set bruges til at ændre værdi af en variabel

        //de bruges til at tildele nye værdier til nye instanser af objektet 'game'
        //her kunne man have gjort noget med access modifiers, for at gøre variabler privat. 
        //det føltes lidt svært.. og måske lidt unødvendigt lige her, da variablerne i objektet skal håndtere spiloplysninger i et 
        //system som håndteres af medarbejdere. 


        public static CreateGame CreateGameFromConsoleInput()
        {
            CreateGame game = new CreateGame(); 
            //konstruktør til opretning af en ny instans af klassen
            //CreateGame med objektet 'game'. 
            //objektet tildeles værdi vha af field-properties defineret ovenfor
            //ved brug af get og set-metode



            Console.WriteLine("\nIndtast ID:");  
                game.id = Console.ReadLine(); //objektet game tildeles værdi i egenskaben id, som indtastes i konsollen. 
            //her bruges getteren ved koden 'game.id = ........' 

                Console.WriteLine("\nIndtast spiltitel: ");
                game.title = Console.ReadLine();

                Console.WriteLine("\nIndtast udgave: ");
                game.edition = Console.ReadLine();

                Console.WriteLine("\nIndtast antal spillere: ");
                game.numberOfPlayers = Console.ReadLine();

            //Før var antal spillere en int, men pga man skal kunne indtaste fx 2-12 spillere. så tænkte jeg string. 
            //  int tempPlayers; //her defineres en slags midlertidig variabel som håndterer antallet af spillere i, dette er en integer
            //    Console.WriteLine("\nIndtast antal spillere:"); 
            //    string playersInput = Console.ReadLine(); //her defineres at indputtet fra konsollen er playersinput, hvilket benyttes i while loopet        
            //      while (!int.TryParse(playersInput, out tempPlayers)) 
            //    //while løkkens betingelse som er 
            //    //while loopet kører så længe det ikke er en integer fra playersInput. 
            //    //while løkken bliver ved at forsøge at parse/konvertere konvertere til heltal 
            //    //men hvis det ikke er et heltal, så kører loopet. 
            //    //og så skal følgende køres indtil der indtastes et gyldigt heltal
            //    //for antal spillere. 
            //    //sagt på en anden måde så længe parsingen ikke finder sted er tryparse falsk.
            //    //så længe parsingen er succesfuld returnere metoden tryparse sand.
                
            //      {
            //        Console.WriteLine("\nUgyldig indtastning. Indtast gyldigt heltal for antal spillere: ");
            //        playersInput = Console.ReadLine(); //når playerinputtet fra konsollen er en integer, så stopper while og der returneres tempplayers
            //      }
            //    game.numberOfPlayers = tempPlayers;
            ////når while løkken er færdig er der der indtasstet et heltal, som gemmes i 
            ////game.numberOfPlayers = tempPlayers; og her bruges get-mtoden ved 'game.numberOfplayers' til at hente den indtastede værdi. 

                Console.WriteLine("\nIndtast sprog:");
                game.language = Console.ReadLine();

                Console.WriteLine("\nIndtast genre:");
                game.genre = Console.ReadLine();

                Console.WriteLine("\nIndtast stand:");
                game.condition = Console.ReadLine();

                double tempPrice; //her er samme princip som ovenfor i linje 51-69 (inkl dokumentation) her er det bare en double i stedet. 
            //og det omhandler prisen på spillet. 
                Console.WriteLine("\nIndtast pris:");
                string priceInput = Console.ReadLine();
                while (!double.TryParse(priceInput, out tempPrice))
                {
                    Console.WriteLine("\nUgyldig indtastning. Indtast gyldig pris:");
                    priceInput = Console.ReadLine();
                }
                game.price = tempPrice; 

                return game;
            //når alle egenskaberne er settet og gettet med værdi fra konsollen så returneres objektet 
                


        }
    }
}

  //  Andre metoder til læsning fra konsollen:

//Console.ReadKey(): Læser en enkelt tast fra konsollen.

//Console.KeyAvailable: Undersøger om tast er tilgængelig i konsollen.

//Yderligere funktioner er:

//Console.Clear(): Rydder konsollen.

//Console.CursorVisible: Gør konsollens cursor synlig eller usynlig.

//Console.Title: Sætter konsollens titel

