using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json; //dette namespace er også indbygget og gør det muligt at bruge json klassen, hvor man nemt kan organisere og konvertere objekter til json-streng og omvendt fra json-streng til objekt. 
using System.Collections.ObjectModel; //Dette namespace er indbygget i .NET Framwork, med denne kan man lave collections. og bruge nogle bestemte keyword

namespace MenuSystem.Methods
{
    public static class GameFileManager
    {
        private static string filePath = "games.json"; 

        public static void SaveGameToFile(CreateGame game)
        {
            // Opretter en liste til spil
            // List<CreateGame> games = new List<CreateGame>();

            //Opretter 
            ICollection<CreateGame> games;

            // Tjekker om filen allerede eksisterer for at indlæse eksisterende spil
            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                games = JsonSerializer.Deserialize<Collection<CreateGame>>(existingJson) ?? new Collection<CreateGame>();
            }

            else
            {
                 games = new Collection<CreateGame>();
            }
            // Tilføjer det nye spil til listen
            games.Add(game);

            // Serialiser listen af spil til en JSON string
            string json = JsonSerializer.Serialize(games, new JsonSerializerOptions { WriteIndented = true });

            // Gemmer JSON stringen i filen
            File.WriteAllText(filePath, json);
        }

        public static List<CreateGame> LoadGamesFromFile()
        {
            // Tjekker om filen eksisterer
            if (!File.Exists(filePath))
            {
                return new List<CreateGame>(); // Returnerer en tom liste, hvis filen ikke findes
            }

            // Læser JSON stringen fra filen
            string json = File.ReadAllText(filePath);

            // Deserialiser JSON stringen til en liste af AddGame objekter
            List<CreateGame> games = JsonSerializer.Deserialize<List<CreateGame>>(json) ?? new List<CreateGame>();

            return games;
        }     
    }
}
