

using System.Security.Cryptography.X509Certificates;

namespace Inlamn2.Classes
{
    public class Actions
    {
        //pcChoice
        //1 = shoot, 2 = load, 3 = block

        public static int PlayerAmmo { get; set; }
        public static int PcAmmo { get; set; }

        public static bool Running = true;

        //public Actions(int playerAmmo, int pcAmmo)
        //{
        //    PlayerAmmo = playerAmmo;
        //    PcAmmo = pcAmmo;
        //}

        public string CompareActions(string btnClick)
        {
            Weapon act = new();

            

            //Skriv som props?
            string pcShot = "Pc Shot";
            string pcLoaded = "Pc Loaded";
            string pcBlocked = "Pc Blocked";

            int pcChoice = Opponent.ComputerChoice(PlayerAmmo, PcAmmo);


            //Autowin with 3 bullets

            //Alternative shoot | Känns som det är bättre?
            if(btnClick == "Shotgun")
            {
                if(pcChoice == 1 && PcAmmo == 3)
                {
                    PlayerAmmo = PlayerAmmo - 1;
                    PcAmmo = PcAmmo - 1;
                    return "Pc used Shotgun";
                }
                else
                {
                    Running = false;
                    return "Win";
                }
            }

            else if (btnClick == "Shoot")
            {
                PlayerAmmo = act.Shoot(PlayerAmmo);

                if (pcChoice == 1 && PcAmmo == 3)
                {
                    Running = false;
                    return "Lose";
                }

                else if(pcChoice == 1)
                {
                    PcAmmo = act.Shoot(PcAmmo);
                    return pcShot;
                }

                else if (pcChoice == 2)
                {
                    Running = false;
                    return "Win";
                }

                else
                {
                    return pcBlocked;
                }
            }

            else if (btnClick == "Load")
            {
                PlayerAmmo = act.Load(PlayerAmmo);
                if (pcChoice == 1)
                {
                    PcAmmo = act.Shoot(PcAmmo);
                    Running = false;
                    return "Lose";
                }

                else if (pcChoice == 2)
                {
                    PcAmmo = act.Load(PcAmmo);
                    return pcLoaded;
                }

                else
                {
                    return pcBlocked;
                }
            }

            else
            {
                if (pcChoice == 1 && PcAmmo == 3)
                {
                    Running = false;
                    return "Lose";
                }

                else if (pcChoice == 1)
                {
                    PcAmmo = act.Shoot(PcAmmo);
                    return pcShot;
                }

                else if (pcChoice == 2)
                {
                    PcAmmo = act.Load(PcAmmo);
                    return pcLoaded;
                }

                else
                {
                    return pcBlocked;
                }
            }
        }

        public void NewGame()
        {
            PlayerAmmo = 0;
            PcAmmo = 0;
            Running = true;
        }

    }
}
