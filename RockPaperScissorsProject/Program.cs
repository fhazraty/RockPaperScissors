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
                    ShowMainMenu();

                    GetValidInput(1, 2,out int input, ShowMainMenu);
                    
                    if (input == 2) break;

                    isInGame = true;
                    Console.Clear();
                    Console.Beep(1000, 500);
                }

                ShowWeaponsMenu();

				GetValidInput(1, 4, out int userWeapon, ShowWeaponsMenu);
				
                if (userWeapon == 4) // Exit to main menu
                {
                    ResetGameScores();
                    isInGame = false;
                    Console.Clear();
                    continue;
                }

                PlayRound((Weapons)userWeapon);
            }
        }

        /// <summary>
        /// نمایش منو اولیه
        /// </summary>
        static void ShowMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\t\t<<<<<<<<<<<<<<< Welcome To The Rock Paper Scissors Game >>>>>>>>>>>>>>>>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Enter The Game");
            Console.WriteLine("2. Exit");
            Console.Write("Please Select An Item: ");
        }

        /// <summary>
        /// نمایش انتخاب های اسلحه
        /// </summary>
        static void ShowWeaponsMenu()
        {
            Console.WriteLine("\n\n==================================================================");
            Console.WriteLine("List of Weapons:");
            Console.WriteLine("1. Paper");
            Console.WriteLine("2. Rock");
            Console.WriteLine("3. Scissors");
            Console.WriteLine("4. Exit to The Main Menu");
            Console.Write("Enter The Weapon You Choose: ");
        }

		/// <summary>
		/// بررسی مقدار وارد شده که در رنج صحیح قرار دارد یا خیر
		/// </summary>
		/// <param name="min">حداقل ممکن</param>
		/// <param name="max">حداکثر ممکن</param>
		/// <param name="validInput">مقدار صحیح درج شده</param>
		static void GetValidInput(int min, int max, out int validInput, Action messageShow)
		{
			while (true)
			{
				if (int.TryParse(Console.ReadLine(), out validInput) && validInput >= min && validInput <= max)
				{
					break; // ورودی معتبر
				}
            
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please try again.");
                Console.ForegroundColor = ConsoleColor.White;
                messageShow();
			}
		}

		/// <summary>
		/// هر مرحله بازی در این متد پیاده شده است.
		/// </summary>
		/// <param name="userWeapon">اسلحه ای که کاربر انتخاب کرده است.</param>
		static void PlayRound(Weapons userWeapon)
        {
            var random = new Random();
            var cpuWeapon = (Weapons)random.Next(1, 4);

            RPS rps = new RPS();
            Winner winner = rps.CheckTheWinner(userWeapon, cpuWeapon);

            Console.WriteLine("\n==================================================================");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"You Chose {userWeapon}");
            Console.WriteLine($"CPU Chose {cpuWeapon}");
            Console.ForegroundColor = ConsoleColor.White;

            switch (winner)
            {
                case Winner.User:
                    RPS.userScore++;
                    ShowResult("User Wins!", ConsoleColor.DarkGreen);
                    break;
                case Winner.CPU:
                    RPS.cpuScore++;
                    ShowResult("CPU Wins!", ConsoleColor.DarkRed);
                    break;
                case Winner.Draw:
                    ShowResult("Draw!", ConsoleColor.DarkYellow);
                    break;
            }

            Console.WriteLine($"Your Score: {RPS.userScore}");
            Console.WriteLine($"CPU's Score: {RPS.cpuScore}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// در هنگام نمایش نتایج از این متد استفاده می شود.
        /// </summary>
        /// <param name="message">پیامی که میخواهیم نمایش داده شود</param>
        /// <param name="color">رنگ پیام</param>
        static void ShowResult(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(500);
        }

        /// <summary>
        /// در این متد دستور ریست کردن بازی پیاده سازی شده است.
        /// </summary>
        static void ResetGameScores()
        {
            RPS.userScore = 0;
            RPS.cpuScore = 0;
        }
    }
}
