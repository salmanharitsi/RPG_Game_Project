using System;

namespace UTS_Dasar_pemrograman
{
    class Player
    {
        public int Blood { get; set; }
        public string Name { get; set; }
        public int Attackpower { get; set; }
        public float Experience { get; set; }
        public bool IsDead { get; set; }
        public bool IsRunningAway { get; set; }
        
        Random rnd = new Random();
        
        public Player(){
            Blood = 100;
            Attackpower = 5;
            Experience = 0f;
            IsDead = false;
            IsRunningAway = false;
        }

        public virtual void Attack(Enemy enemy){
            Console.WriteLine("Skill : Sword Attack");
            Attackpower = rnd.Next(3,6);
        }

        public virtual void Defend(){
            Console.WriteLine("Defend!!");
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+ " get hit by " +hitValue);
            Blood = Blood - hitValue;

            if(Blood <= 0){
                Blood = 0;
                Die();
            }
        }

        public void Die(){
            Console.WriteLine("");
            Console.WriteLine("You are dead");
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Lets playing again!!");
            Console.Read();
            IsDead = true;
            Environment.Exit(0);
            
        }

        public void RunAway(){
            Console.WriteLine("");
            Console.WriteLine("you run away");
            Console.WriteLine("such as LOSER!!");
            Console.WriteLine("Game Over");
            Console.Read();
            IsRunningAway = true;
            Environment.Exit(0);

        }
    }
}           