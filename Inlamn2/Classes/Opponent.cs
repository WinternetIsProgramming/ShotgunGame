namespace Inlamn2.Classes
{
    public static class Opponent
    {
        public static int ComputerChoice(int playerAmmo, int pcAmmo)
        {
            Random random = new();

            if (pcAmmo == 3)
            {
                return 1;
            }

            else if (playerAmmo == 0 && pcAmmo > 0)
            {
                return random.Next(1, 3);
            }

            else if (playerAmmo == 0 && pcAmmo == 0)
            {
                return 2;
            }

            else if (pcAmmo == 0)
            {
                return random.Next(2, 4);
            }

            else
            {
                return random.Next(1, 4);
            }
        }
    }
}
