using System;

namespace UTS_Dasar_pemrograman
{
    class Enemy
    {
        public int Blood { get; set; }
        public string Name { get; set; }
        public int Attackpower { get; set; }
        public bool IsDead { get; set; }
        public bool IsStunned { get; set; }
        
        Random rnd = new Random();
      
        public void GetHit(int hitValue){
            Console.WriteLine(Name+ " get hit by " +hitValue);
            Blood = Blood - hitValue;

            if (Blood <= 0){
                Blood = 0;
                Die();
            }
        }
        public void Die(){
            Console.WriteLine(Name+ " is dead");
            IsDead = true;
        }

        public virtual void Attack(Player player){
            player.GetHit(2* Attackpower);
        }

        public virtual void BossAttack(Player player){
            player.GetHit(3* Attackpower);
        }
        
    }
}