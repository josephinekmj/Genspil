
using System.Security.Cryptography.X509Certificates;
using MenuSystem.Methods;

namespace MenuSystem.Menu
{
    public class Program
    {
        public static void Main()
        {
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Console.WriteLine("   ____                      _ _ ");
            //Console.WriteLine("  / ___| ____ _ __  ___ _ __ (_) |");
            //Console.WriteLine(" | |  _ / _ \\ '_ \\/ __| '_ \\| | |");
            //Console.WriteLine(" | |_| |   __/ | | \\__ \\ |_) | | |");
            //Console.WriteLine(" \\____|\\___|_| |_|___/ .__/|_|_|");
            //Console.WriteLine("                      |_|     ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\r\n                                                                                      \r\n ░▒▓██████▓▒░░▒▓████████▓▒░▒▓███████▓▒░ ░▒▓███████▓▒░▒▓███████▓▒░░▒▓█▓▒░▒▓█▓▒░        \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░▒▓█▓▒░        \r\n░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░▒▓█▓▒░        \r\n░▒▓█▓▒▒▓███▓▒░▒▓██████▓▒░ ░▒▓█▓▒░░▒▓█▓▒░░▒▓██████▓▒░░▒▓███████▓▒░░▒▓█▓▒░▒▓█▓▒░        \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░        \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░        \r\n ░▒▓██████▓▒░░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░░▒▓█▓▒░      ░▒▓█▓▒░▒▓████████▓▒░ \r\n                                                                                      \r\n                                                                                      \r\n");
            Console.ResetColor();

            Menu menuObject = new Menu("\t\t\nKære medarbejder hos Genspil\n");

            //// Temaet fra Avengers
            //Console.Beep(440, 500); // A4
            //Console.Beep(440, 500); // A4
            //Console.Beep(440, 500); // A4
            //Console.Beep(349, 350); // F4
            //Console.Beep(523, 150); // C5
            //Console.Beep(440, 500); // A4
            //Console.Beep(349, 350); // F4
            //Console.Beep(523, 150); // C5
            //Console.Beep(440, 1000); // A4

            //// Lille pause mellem temaerne
            //Thread.Sleep(200);

            //// Gentag temaet
            //Console.Beep(659, 500); // E5
            //Console.Beep(659, 500); // E5
            //Console.Beep(659, 500); // E5
            //Console.Beep(698, 350); // F5
            //Console.Beep(523, 150); // C5
            //Console.Beep(415, 500); // G#4
            //Console.Beep(349, 350); // F4
            //Console.Beep(523, 150); // C5
            //Console.Beep(440, 1000); // A4

            //// Lille pause mellem temaerne
            //Thread.Sleep(200);


                menuObject.AddMenuItem(new MenuItem("\n1. Tilføj brætspil"));
                menuObject.AddMenuItem(new MenuItem("\n2. Fjern brætspil"));
                menuObject.AddMenuItem(new MenuItem("\n3. Vis alle brætspil"));
                menuObject.AddMenuItem(new MenuItem("\n4. Tilføj kunde"));
                menuObject.AddMenuItem(new MenuItem("\n5. Tilføj ordre"));
                menuObject.AddMenuItem(new MenuItem("\n6. Tilføj forespørgsel"));
                menuObject.AddMenuItem(new MenuItem("\n7. Fjern forespørgsel"));
                menuObject.AddMenuItem(new MenuItem("\n8. Søg efter bestemt brætspil\n\n"));


                menuObject.Show();

                int menuPoint = menuObject.SelectMenuItem();

            switch (menuPoint)
            {

                case 1:
                    CreateGame game = CreateGame.CreateGameFromConsoleInput();
                    //  Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("\n\n...METODE SOM OPRETTER ET BRÆTSPIL...\n\n");
                    GameFileManager.SaveGameToFile(game);
                    Console.WriteLine("\nSpillet er nu gemt. For at vende tilbage til menuen tryk på T derefter Enter: ");
                    if (Console.ReadLine() == "T")
                        Main();
                    else
                    {
                        Console.WriteLine("\nUgyldig indtastning. Tryk på T og derefter Enter: ");
                    }

                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("\nIndtast ID på spillet, du vil slette: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteId))
                    {
                        DeleteGameFromFileUsingConsole.DeleteGameFromFile(deleteId);
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt ID. Prøv igen: ");
                    }
                    
                    Main();
                    break;
                case 3:
                    ShowAllGames.ShowAllGamesFromFile();
                    Main();
                    break;
                case 4:
                    
                    Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("\n\n...METODE SOM OPRETTER KUNDE...\n\n");
                            
                     Main(); 
                   
                    
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\n\n...... METODE SOM FJERNER ET BRÆTSPIL.....\n\n");
                        Main();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n\n...... METODE SOM FJERNER EN FORESPØRGSEL.....\n\n");
                        Main();
                        break;
                    case 7:                                      //Metode som Fjerner forespørgsel
                    Console.WriteLine("\n\n -..... Fjerner brætspil ..... indsæt metode");      
                        Main();
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("\n\n...SØG EFTER BRÆTSPIL...\n\n");
                        Main();
                        break;


                    default:

                        break;

                }



            }


        } 
    }