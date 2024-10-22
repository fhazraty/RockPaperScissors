using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;

namespace RockPaperScissorsProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isInGame = false;

            while (true)
            {
                if (!isInGame)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\n\t\t<<<<<<<<<<<<<<< Welcome To The Rock Paper Scissors Game >>>>>>>>>>>>>>>>");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1.Enter The Game");
                    Console.WriteLine("2.Exit");
                    Console.Write("Please Select An Item : ");
                    int input;

                    if (!int.TryParse(Console.ReadLine(), out input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong Input, Please Try Again");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }

                    if (input < 1 || input > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong Input, Please Try Again");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }

                    if (input == 2)
                    {
                        break;
                    }

                    isInGame = true;

                    Console.Clear();
                    Console.Beep(1000, 500);
                }

                Console.WriteLine("\n\n==================================================================");
                Console.WriteLine("List of Weapons : ");
                Console.WriteLine("1.Paper");
                Console.WriteLine("2.Rock");
                Console.WriteLine("3.Scissors");
                Console.WriteLine("4.Exit to The Main Menu");
                Console.Write("Enter The Weapon You Choose : ");
                int userWeapon;

                if (!int.TryParse(Console.ReadLine(), out userWeapon))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There is No Such Weapon. Please Try Again.");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                if (userWeapon < 1 || userWeapon > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There is No Such Weapon. Please Try Again.");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                var random = new Random();
                var cpuRandom = random.Next(1, 4);

                RPS rps = new RPS();
                Winner winner = rps.CheckTheWinner((Weapons)userWeapon, (Weapons)cpuRandom);

                Console.WriteLine("\n==================================================================");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"You Chose {((Weapons)userWeapon).ToString()}");
                Console.WriteLine($"CPU Chose {((Weapons)cpuRandom).ToString()}");
                Console.ForegroundColor = ConsoleColor.White;

                switch (winner)
                {
                    case Winner.User:
                        RPS.userScore += 1;
                        Thread.Sleep(500);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("User Wins!");
                        break;

                    case Winner.CPU:
                        RPS.cpuScore += 1;
                        Thread.Sleep(500);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("CPU Wins!");
                        break;

                    case Winner.Draw:
                        Thread.Sleep(500);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Draw!");
                        break;
                }
                Console.WriteLine($"Your Score : {RPS.userScore}");
                Console.WriteLine($"CPU's Score : {RPS.cpuScore}");
                Console.ForegroundColor = ConsoleColor.White;

                if (userWeapon == 4)
                {
                    RPS.cpuScore = 0;
                    RPS.userScore = 0;
                    isInGame = false;
                    Console.Clear();
                }
            }
        }
    }
}

