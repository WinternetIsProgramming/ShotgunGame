namespace Inlamn2.Classes
{
    public class Weapon
    {

        public int Shoot(int ammo)
        {
            return ammo-1;
        }

        public int Load(int ammo)
        {
            return ammo + 1;
        }
    }
}
