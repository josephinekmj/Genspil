

using System;
using System.Collections.Generic;
using MenuSystem.Menu;
using MenuSystem.Methods;

namespace MenuSystem.Methods
{
    public class ShowAllGames
    {
        public static void ShowAllGamesFromFile()
        {
            List<CreateGame> games = GameFileManager.LoadGamesFromFile();
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var game in games)
            {
                Console.WriteLine($"\nID: {game.id}\nTitel: {game.title}\nAntal spillere: {game.numberOfPlayers}\nSprog: {game.language}\nGenre: {game.genre}\nStand: {game.condition}\nPris: {game.price}\n");
            }
            Program.Main(); // Tilbage til hovedmenuen efter visning af spil
        }
    }
}