namespace simple_game_abstraction.entities
{
    public class Arus : Character
    {
        public Arus(string Name, string HeroType, string Weapon, int Level, int HP, int MP)
        {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
            this.Level = Level;
            this.HP = HP;
            this.MP = MP;
        }
    }
}