namespace _03BarracksFactory.Models.Units
{
    public class Horsemen : Unit
    {
        private const int DefaultHealth = 50;
        private const int DefaultDamage = 10;

        public Horsemen()
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
