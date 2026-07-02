using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
<<<<<<< Updated upstream
     public class Character
    {
        
        public int Health { get; private set; } = 100;
         public void Hit (int damage)
        {

             if (damage > Health)
                damage = Health;
            Health -= damage;
            
        }
    }
}
=======
  
        public class Character
        {
     

          private static int speed = 10;
          public int Heath { get; set; } = 100;
           public string Race { get; private set; }
           public int Armor { get; set; }
             //конструктор нужен для защиты состояния класса.
           public Character(string race)
           {
               Race = race;
              Armor = 30;
            }
            public Character(string race, int armor)
            {
               Race = race;
              Armor = armor;
          }
       }
    }

>>>>>>> Stashed changes
