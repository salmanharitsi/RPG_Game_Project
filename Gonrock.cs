using System;

namespace UTS_Dasar_pemrograman
{
    class Gonrock : Player
    {
        public int StunPoint { get; set; }
        public static int StunDuration = 3;
        Random rnd = new Random();

        public Gonrock(){
            Blood = 500;
            Attackpower = rnd.Next(10,16);
            StunPoint = 0;
            Name = "Gonrock";
        }

        public override void Attack(Enemy enemy){
            
            if (StunPoint >= 3){
                StunDuration = 3;
                Console.WriteLine("STUN ATTACK");
                Console.WriteLine("SHPPP!!");
                Console.WriteLine(enemy.Name+ " get stun for " +StunDuration+ " seconds");
                enemy.IsStunned = true;
                enemy.GetHit(8* Attackpower);
                StunPoint = StunPoint - 3;
            }else{
                Console.WriteLine("Stun Point : " +StunPoint);
                Console.WriteLine("you dont have enough stun point..");
                Console.WriteLine("Lets defend to get stun point!!!");
            }
        }

        public override void Defend()
        {
            Console.WriteLine("DEFEND!!");
            Console.WriteLine("you get 1 stunpoint");
            StunPoint = StunPoint + 1;
        }
    }
}