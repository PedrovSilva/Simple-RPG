namespace simple_game_abstraction.entities
{
    public abstract class Character
    {
      

    
          public string Name = "a";

          public string HeroType = "a";

          public string Weapon = "A";

          public int Level;

          public int HP;

          public int MP;
    

        public override string ToString()
        {
            return this.Name + "\n" + "Lv: " + this.Level + "\n" + "Class: " + this.HeroType + "\n" + "Weapon: " + this.Weapon + "\n" + "HP: " + this.HP + "\n" + "MP: " + this.MP + "\n" + "_________________________________________";
        }


        public virtual string Attack(int Damage)
        {
            return this.Name + " Attacked the enemy causing " + Damage + " of damage";
        }
    }
}