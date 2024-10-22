namespace RockPaperScissorsProject;

public class RPS
{
    public static int userScore = 0;
    public static int cpuScore = 0;
    
    public Winner CheckTheWinner(Weapons user, Weapons cpu)
    {
        int userWeapon = (int)user;
        int cpuWeapon = (int)cpu;

        if (userWeapon == cpuWeapon)
            return Winner.Draw;

        if (userWeapon == 3 && cpuWeapon == 1)
        {
            return Winner.User;
        }

        if (userWeapon == 1 && cpuWeapon == 3)
        {
            return Winner.CPU;
        }

        if (userWeapon < cpuWeapon)
        {
            return Winner.User;
        }

        return Winner.CPU;
    }



}