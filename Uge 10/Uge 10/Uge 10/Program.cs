using System.Collections.Generic;
using System;
using System.Data.SqlTypes;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq.Expressions;

namespace Uge_10
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // ØVELSE 1

            // Øvelse 1.1 - Alderen på alle i gruppen, samt aldersgennemsnit (uden array)
            // Øvelse 1.2.1: Erklær og tildel
            // Øvelse 1.3: Findes der en med alderen
            // Øvelse 1.4: Bestemt antal personer
            // Øvelse 1.4.1: try-catch
            // Øvelse 1.4.2: int.TryParse

            //bool validInput = false;
            //do
            //{
            //    int numberOfPersons = 0;


            //    int ageOfPersons = 0;
            //    string ageOfPers = "";

            //    Console.Write("Indtast venligst antallet af personer i gruppen: ");


            //    if (!int.TryParse(Console.ReadLine(), out numberOfPersons))
            //        continue;


            //    int[] ages = new int[numberOfPersons];

            //    int i = 0;
            //    foreach (int person in ages)
            //    {
            //        Console.Write("Indtast venligst en alder på en person: ");
            //        ageOfPers = Console.ReadLine();

            //        if (!int.TryParse(ageOfPers, out ageOfPersons))
            //            continue;

            //        ages[i] = ageOfPersons;

            //        i++;
            //    }

            //    Console.ReadKey();


            //} while (validInput != true);


            // erklæring og initialisering 
            //sum er en variabel, der initialiseres til 0 før løkken begynder.
            //          I hver iteration af løkken tilføjes værdien af age(den aktuelle alder i arrayet) til sum.
            //          Dette gentages for hver alder i arrayet,
            //          så ved slutningen af løkken indeholder sum summen af alle aldre i arrayet.
            //          Så sum += age; kan ses som en kort måde at skrive sum = sum + age;.
            //          Det er en almindelig idiom i programmeringssprog som C# for at gøre koden mere kompakt.


            //int[] ageArray = { 22, 32, 24, 67 };

            //int sum = 0;
            //foreach (int age in ageArray)
            //{
            //  sum += age;
            //}

            ////opretter en variabel af datatypen double, for at håndtere decimaltal
            //double avAge = (double)sum/ageArray.Length;

            //Console.WriteLine("Gennemsnitsalderen er: " + avAge + " år.");

            ////søgefunktionen

            //Console.WriteLine("Alderen du vil søge efter: ");
            //int searchAge = int.Parse(Console.ReadLine());

            //foreach (int age in ageArray)
            //{

            //    // hvis "age" er lig med "search age" så køres koden inde i {} 
            //    if (age == searchAge)
            //    {
            //        Console.WriteLine($"{searchAge} findes i arrayet.");
            //     break; //når alderen er fundet, skal loopet stoppes. 
            //    }
            //}

            //Console.ReadKey();
            //I C# (C-sharp bruges dollartegnet ($) som en del af interpolated strings.
            //Interpolerede strenge gør det lettere at inkludere variabler og udtryk i en streng
            //uden at skulle konkatenerer dem ved hjælp af +.
            //interpolerede strenge er en funktion, som er mere bekvem når der skal inkluderes
            //variabler og udtryk i en streng.
            //$-tegnet er præfiks (sættes foran) og gør det muligt at
            //indlejre variabler og udtryk ved blot at placere dem i krølleparanteser {}
            //variabel navne og udtryk erstattes med deres værdier. det gør at man ikke behøver konkatinering med +.  


            //øvelse 1.4 
            //  Det skal være muligt for en bruger af dit program
            //  at definere antallet af personer, der er i en givet gruppe
            //  – for dernæst at tilføje deres aldre.
            //  Du skal med andre ord erklære en variabel
            //  til at indeholde brugerinput omkring antallet af personer i en gruppe,
            //  for derefter at sætte størrelsen af dit array
            //  til at være lig med denne variabel.


            //Console.Write("Intast antal personer i gruppen: ");
            //int numOfPers = int.Parse(Console.ReadLine());
            ////her oprettes en variabel numOfPers af datatypen int med input fra konsollen, parse konvertere streng til int

            ////et array oprettes med numOfPers indtastning
            //int[] ageArray = new int[numOfPers];

            ////et for loop skal indholde indtastninger på aldre
            //for (int i = 0; i < numOfPers; i++)
            //// int i = 0; er en tæller, hvor startværdien er 0
            //// i < numOfPers; er en betingelse som foreskriver, at loopet forsætter, så længe i/tælleren er mindre end værdien af numOfPers. 
            //// i++ øger tælleren med 1 for hver gentagelse/iteration 
            ////nedenstående køres for hver iteration.
            //{
            //    try
            //    {
            //        Console.Write($"Indtast alder for person {i + 1}: ");
            //        ageArray[i] = int.Parse(Console.ReadLine());

            //        //ageArray[i] linjen læser brugerinputtet og konverterer det til integer samtidig med at gemme i ageArray'et. 
            //    }
            //    catch (FormatException) //
            //    {
            //        Console.WriteLine("Fejl i indtastastning, indtast et gyldigt heltal som angiver alderen.");
            //        i--;
            //    }
            //}
            ////gennemsnitsalderen. 
            //int sum = 0;
            //foreach (int age in ageArray)
            //{
            //    sum += age;
            //}

            //double avAge = (double)sum / numOfPers;
            //Console.WriteLine("Gennemsnitsalderen er: " + avAge);

            //// søgefunktion

            //Console.WriteLine("Alderen du vil søge efter: ");
            //int searchAge;

            //try
            //{
            //    searchAge = int.Parse(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("Fejl i indtastastning, indtast et gyldigt heltal som angiver alderen du søger efter.");
            //    return; //afslut program ved fejl
            //}
            //foreach (int age in ageArray)
            //{

            //    // hvis "age" er lig med "search age" så køres koden inde i {} 
            //    if (age == searchAge)
            //    {
            //        Console.WriteLine($"{searchAge} findes i arrayet.");
            //        break; //når alderen er fundet, skal loopet stoppes. 
            //    }
            //}
            //Console.ReadKey();


            //øveæse 1.4.2


           // Console.Write("Intast antal personer i gruppen: ");
           // int numOfPers = int.Parse(Console.ReadLine());
           // //her oprettes en variabel numOfPers af datatypen int med input fra konsollen, parse konvertere streng til int


           ////if med tryparse bruges til at håndtere fejl i indtastninger.

           // if(!int.TryParse(Console.ReadLine(), out numOfPers))
           // {
           //     Console.WriteLine("Fejl i indtastning. Indtast heltal for at indtaste antal personer i gruppen");
           //     return; //afsluutter ved fejl. 
           // }


           // //et array oprettes med numOfPers indtastning
           // int[] ageArray = new int[numOfPers];

           // //et for loop skal indholde indtastninger på aldre
           // for (int i = 0; i < numOfPers; i++)
           // // int i = 0; er en tæller, hvor startværdien er 0
           // // i < numOfPers; er en betingelse som foreskriver, at loopet forsætter, så længe i/tælleren er mindre end værdien af numOfPers. 
           // // i++ øger tælleren med 1 for hver gentagelse/iteration 
           // //nedenstående køres for hver iteration.
           // {
           //     Console.Write($"Indtast alder for person {i + 1}: ");
           //     if (!int.TryParse(Console.ReadLine(), out ageArray[i]))
           //     {
           //         Console.WriteLine("Fejl: Indtast venligst et gyldigt heltal for alderen.");
           //         i--; //gå tilbage til forrige iteration, 
           //     }
           //     ageArray[i] = int.Parse(Console.ReadLine());

                  
              
           // }
           // //gennemsnitsalderen. 
           // int sum = 0;
           // foreach (int age in ageArray)
           // {
           //     sum += age;
           // }

           // double avAge = (double)sum / numOfPers;
           // Console.WriteLine("Gennemsnitsalderen er: " + avAge);

           // // søgefunktion

           // Console.WriteLine("Alderen du vil søge efter: ");
           // int searchAge;

           // if (!int.TryParse(Console.ReadLine(), out searchAge))
           // {
           //     Console.WriteLine("Fejl: Indtast venligst et gyldigt heltal for søgealderen.");
           //     return; // Afslut programmet ved fejl
           // }
           // foreach (int age in ageArray)
           // {

           //     // hvis "age" er lig med "search age" så køres koden inde i {} 
           //     if (age == searchAge)
           //     {
           //         Console.WriteLine($"{searchAge} findes i arrayet.");
           //         break; //når alderen er fundet, skal loopet stoppes. 
           //     }
           // }

           // //I dette program bruger vi int.TryParse til at forsøge at konvertere brugerinputtet til et heltal.
           // //Hvis konverteringen mislykkes, håndterer vi fejlen og beder brugeren om at indtaste input igen.
           // //Denne metode er mere effektiv end try-catch-blokke, når du forventer, at det er almindeligt,
           // //at indtastningen ikke er af den forventede type.

           // Console.ReadKey();



        }
    }
}




