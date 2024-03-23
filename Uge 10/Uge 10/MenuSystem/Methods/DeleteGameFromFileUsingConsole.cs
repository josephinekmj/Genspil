using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; //husk at kalde systemet json (javascript object notation)

namespace MenuSystem.Methods
{
    public class DeleteGameFromFileUsingConsole //denne klasse tillader sletning af et spil fra fil gennem konsollen.
    {
        private static string filePath = "games.json"; // Adgang til filePath fra GameFileManager

        public static void DeleteGameFromFile(int gameId)
        {
            List<CreateGame> games = GameFileManager.LoadGamesFromFile(); // Brug LoadGamesFromFile fra GameFileManager

            // Udskriv listen af spil før sletning for at kontrollere, om data er indlæst korrekt
            Console.WriteLine("Alle spil før sletning: \n");
            foreach (var game in games)
            {
                Console.WriteLine($"ID: {game.id}, Titel: {game.title}");
            }

            CreateGame gameToRemove = games.Find(game => game.id == gameId.ToString()); ;

            if (gameToRemove != null)
            {
                games.Remove(gameToRemove);

                string json = JsonSerializer.Serialize(games, new JsonSerializerOptions { WriteIndented = true });

                try
                {
                    File.WriteAllText(filePath, json);
                    Console.WriteLine($"\nSpil med ID {gameId} er blevet slettet.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fejl ved sletning af spil: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Spil med ID {gameId} blev ikke fundet.");
            }
        }
    }
}