namespace simple_game_abstraction.entities
{
    public abstract class Character
    {
          public string Name { get; set; }
          
          public string HeroType { get; set;}

          public string Weapon { get; set; }

          public int Level { get; set; }

          public int HP { get; set; }

          public int MP { get; set; }
    

        public override string ToString()
        {
            return $"\n {this.Name } \n  Lv: {this.Level} \n  Class: {this.HeroType} \n  Weapon: {this.Weapon} \n  HP: {this.HP}  \n  MP: {this.MP} \n _________________________________________";
        }


        public string Attack(int Damage)
        {
            return $"{this.Name} Attacked the enemy causing {Damage} of damage";
        }

        public string Attack(int Damage, int MPlost)
        {
            
            return $"{this.Name} Attacked the enemy using magic, causing {Damage} of damage. \n -{MPlost}MP ";
             
        }    
    }

}